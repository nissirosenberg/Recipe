use HeartyHearthDB
go 
drop table if exists CookbookRecipe
go
drop table if exists Cookbook
go
drop table if exists MealCourseRecipe
go
drop table if exists MealCourse
go 
drop table if exists Course 
go
drop table if exists Meal 
go
drop table if exists RecipeDirections
go 
drop table if exists RecipeIngredient
go
drop table if exists Recipe
go 
drop table if exists Users
go 
drop table if exists Ingredient
go 
drop table if exists Measurement
go 
drop table if exists CuisineType
go 

create table dbo.CuisineType(
    CuisineTypeId int not null identity primary key,
    CuisineTypeName varchar(35) not null 
        constraint c_CuisineType_Cuisine_type_name_cannot_be_blank check(CuisineTypeName > '')
        constraint u_CuisineType_CuisineTypeName unique,
)

create table dbo.Measurement(
    MeasurementId int not null identity primary key, 
    MeasurementName varchar(30) not null 
        constraint c_Measurement_Measurement_name_cannot_be_blank check(MeasurementName > '')
        constraint u_Measurement_MeasurementName unique 
)

create table dbo.Ingredient(
    IngredientId int not null identity primary key, 
    IngredientName varchar(40) not null 
        constraint c_Ingredient_Ingredient_name_cannot_be_blank check(IngredientName > '')
        constraint u_Ingredient_IngredientName unique,
    IngredientPicture as concat('Ingredient-', translate(IngredientName, ' ', '-'), '.jpg') persisted
)

create table dbo.Users(
    UserId int not null identity primary key, 
    UserFirstName varchar(40) not null 
        constraint c_Users_User_first_name_cannot_be_blank check(UserFirstName > ''),
    UserLastName varchar(40) not null
        constraint c_Users_User_last_name_cannot_be_blank check(UserLastName > ''),
    UserName varchar(50) not null 
        constraint c_Users_User_name_cannot_be_blank check(UserName > '')
        constraint u_Users_UserName unique     
)

create table dbo.Recipe(
    RecipeId int not null identity primary key, 
    UserId int not null 
        constraint f_Users_Recipe foreign key references Users(UserId),
    CuisineTypeId int not null 
        constraint f_CuisineType_Recipe foreign key references CuisineType(CuisineTypeId),
    RecipeName varchar(100) not null 
        constraint c_Recipe_Recipe_name_cannot_be_blank check(RecipeName >'')
        constraint c_Recipe_RecipeName unique,
    Calories int not null 
        constraint c_Recipe_Calories_must_be_0_or_above check(Calories >= 0),
    DateDrafted datetime not null--default getdate() 
        constraint c_Recipe_Date_drafted_must_be_after_January_1_2020 check(DateDrafted > '2020-01-01'),
    DatePublished datetime,
    DateArchived datetime,
    CurrentStatus as case 
                when DateArchived is null then (case 
                                                    when DatePublished is null then 'Draft'
                                                    else 'Published'
                                                    end)
                else 'Archived'
                end persisted,
    RecipePicture as concat('Recipe-', translate(RecipeName, ' ', '-'), '.jpg') persisted,
    Constraint c_Recipe_Date_drafted_must_be_before_date_archived check(DateDrafted < DateArchived),
    Constraint c_Recipe_Date_published_must_be_between_date_drafted_and_date_archived check(DatePublished between DateDrafted and DateArchived)
)


create table dbo.RecipeIngredient(
    RecipeIngredientId int not null identity primary key, 
    RecipeId int not null 
        constraint f_Recipe_RecipeIngredient foreign key references Recipe(RecipeId), 
    MeasurementId int 
        constraint f_Measurement_RecipeIngredient foreign key references Measurement(MeasurementId), 
    IngredientId int not null 
        constraint f_Ingredient_RecipeIngredient foreign key references Ingredient(IngredientId),
    Amount decimal (4,2) not null 
        constraint c_RecipeIngredient_Amount_must_be_above_0 check(Amount > 0),
    IngredientSequence int not null  
        constraint c_RecipeIngredient_Ingredient_Sequence_must_be_above_0 check(IngredientSequence > 0), 
    Constraint u_Recipe_IngredientSequence_RecipeId unique(IngredientSequence, RecipeId),
    Constraint u_Recipe_IngredientId_RecipeId unique(IngredientId, RecipeId)
)


create table dbo.RecipeDirections(
    RecipeDirectionsId int not null identity primary key,
    RecipeId int not null 
        constraint f_Recipe_RecipeDirections foreign key references Recipe(RecipeId),
    DirectionsSequence int not null 
        constraint c_RecipeDirections_Directions_sequence_must_be_above_0 check(DirectionsSequence > 0),
    Directions varchar(500) not null 
        constraint c_RecipeDirections_Directions_cannot_be_blank check(Directions > ''),
    Constraint u_RecipeDirections_DirectionsSequence_RecipeId unique(DirectionsSequence, RecipeId)
)


create table dbo.Meal(
    MealId int not null identity primary key,
    UserId int not null 
        constraint f_Users_Meal foreign key references Users(UserId),
    MealName varchar(75) not null 
        constraint c_Meal_Meal_name_cannot_be_blank check(MealName > '')
        constraint u_Meal_MealName unique,
    Active bit not null default 1,
    DateCreated date not null
        constraint c_Meal_Date_created_must_be_after_January_1_2020 check(DateCreated > '2020-01-01')
)

create table dbo.Course(
    CourseId int not null identity primary key, 
    CourseSequence int not null 
        constraint c_Course_Course_sequence_must_be_above_0 check(CourseSequence > 0)
        constraint u_Course_CourseSequence unique,
    CourseName varchar(75) not null 
        constraint c_Course_Course_name_cannot_be_blank check(CourseName > '')
        constraint u_Course_CourseName unique 
)

create table dbo.MealCourse(
    MealCourseId int not null identity primary key,
    MealId int not null 
        constraint f_Meal_MealCourse foreign key references Meal(MealId),
    CourseId int not null 
        constraint f_Course_MealCourse foreign key references Course(CourseId),
    Constraint u_MealCourse_MealId_CourseId unique(MealId, CourseId)
)

create table dbo.MealCourseRecipe(
    MealCourseRecipeId int not null identity primary key,
    MealCourseId int not null 
        constraint f_MealCourse_MealCourseRecipe foreign key references MealCourse(MealCourseId),
    RecipeId int not null 
        constraint f_Recipe_MealCourseRecipe foreign key references Recipe(RecipeId),
    MainDish bit not null,
    Constraint u_MealCourseRecipe_MealCourseId_RecipeId unique(MealCourseId, RecipeId)
)

create table dbo.Cookbook(
    CookbookId int not null identity primary key,
    UserId int not null 
        constraint f_Users_Cookbook foreign key references Users(UserId),
    CookbookName varchar(100) not null 
        constraint c_Cookbook_Cookbook_name_cannot_be_blank check(CookbookName > '')
        constraint u_Cookbook_CookbookName unique,
    Price decimal(5,2) not null 
        constraint c_Cookbook_Price_must_be_above_0 check(Price > 0),
    Active bit not null default 1,
    DateCreated date not null 
        constraint c_Cookbook_Date_created_must_be_after_January_1_2020 check(DateCreated > '2020-01-01'),
    CookbookPicture as concat('Cookbook-', translate(CookbookName, ' ', '-'), '.jpg') persisted
)

create table dbo.CookbookRecipe(
    CookbookRecipeId int not null identity primary key,
    CookbookId int not null 
        constraint f_Cookbook_CookbookRecipe foreign key references Cookbook(CookbookId),
    RecipeId int not null 
        constraint f_Recipe_CookbookRecipe foreign key references Recipe(RecipeId),
    RecipeSequence int not null 
        constraint c_CookbookRecipe_Recipe_sequence_must_be_above_0 check(RecipeSequence > 0),
    Constraint u_CookbookRecipe_CookbookId_RecipeSequence unique(CookbookId, RecipeSequence),
    Constraint u_CookbookRecipe_CookbookId_RecipeId unique(CookbookId, RecipeId)
)