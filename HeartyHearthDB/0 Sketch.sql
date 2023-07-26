-- SM Excellent sketch! See comments,I believe you can start creating the database. Good luck! If you need clarification please reach out to me on slack.
--Hearty Hearth Sketch

/*
Cuisine Type:
CuisineTypeId int 
    not null 
    identity
    primary key
CuisineTypeName varchar(35) 
    not null
    not ''
    unique
*/

/*
Measurement:
MeasurementId int
    not null
    identity
    primary key
MeasurementName varchar(30)
    not null
    not ''
    unique
*/

/*
Ingredient:
IngredientId int 
    not null
    identity
    primary key
IngredientName varchar(40)
    not null
    not ''
    unique
IngredientPicture 
    computed as (tablename, -, IngredientName until space(, -, IngredientName after space))
*/


/*
User:
UserId int 
    not null
    identity
    primary key
UserFirstName varchar(40)
    not null
    not ''
UserLastName varchar(40)
    not null
    not ''
UserName varchar(50)
    not null
    not ''
    unique
*/

/*
Recipe:
RecipeId int
    not null
    identity
    primary key
RecipeName varchar(100)
    not null
    not ''
    unique
CuisineTypeId int
    not null
    foreign key references CuisineType(CuisineTypeId)
Calories int
    not null 
    constraint must be >= 0
RecipePicture
    computed as (tablename, -, RecipeName until space(), -, RecipeName from space))
UserId int 
    not null
    foreign key references User(UserId)
Status  
-- SM The way you should do this is, use nested case, check on one column if it's null/not null, 
--then case other column is null/not null, then it should be one status else other status end, else it should be third status.
-- This would be the most concise way to do it without repeating twice any check on any column
    computed as: when DatePublished and DateArchived is null then 'Draft'
                 when DateArchived is null then 'Published'
                 when DatePublished is null then 'Archived'
                 other 'Archived'
DateCreated datetime
    not null
    must be after '2020-01-01
DatePublished datetime
DateArchived datetime
-- SM Consrtaint should be that dates should be in order, drafted - published (if it was) - archived. 
Constraint DateCreated must be before DatePublished and DateArchived
*/


/*
RecipeIngredients:
RecipeIngredientsId int
    not null
    identity
    primary key
RecipeId int
    not null
    foreign key references Recipe(RecipeId)
Amount decimal(4,2)
    not null
    must be above 0 
MeasurementId int 
    foreign key references Measurement(MeasurementId)
IngredientSequence int 
    not null
    must be above 0
IngredientId int 
    not null
    foreign key references Ingredient(IngredientId)
Constraint IngredientSequence and RecipeId unique
Constraint IngredientId and RecipeId unique
--Is there a way to do this in one constraint? (like RecipeId and (IngredientSequence or Ingredient Id))
-- SM No, not with unique constraint, and I don't see why you want it. It would be better for you to know what 2 values are a problem.
*/

/*
RecipeDirections:
RecipeDirectionsId int 
    not null
    identity
    primary key
RecipeId int 
    not null
    foreign key references Recipe(RecipeId)
DirectionsSequence int 
    not null
    must be above 0
Directions varchar(500)
    not null
    not ''
Constraint DirectionsSequence and RecipeId unique
*/


/*
Meal:
MealId int
    not null
    identity
    primary key
MealName varchar(75)
    not null
    not '' 
    unique
Active bit 
    not null
DateCreated date 
    not null
    must be after '2020-01-01
UserId int 
    not null
    foreign key references User(UserId)j
*/

/*
Course:
CourseId int 
    not null 
    identity
    primary key
CourseSequence int 
    not null
    must be above 0
    unique
CourseName varchar(75)
    not null 
    not ''
    unique
*/


/*
MealCourse:
MealCourseId int 
    not null
    identity
    primary key
MealId int 
    not null
    foreign key references Meal(MealId)
CourseId int 
    not null 
    foreign key references CourseType(CourseTypeId)
Constraint MealId and CourseId must be unique
*/

/*
MealCourseRecipe:
MealCourseRecipeId int
    not null
    identity
    primary key
MealCourseId int
    not null
    foreign key references Course(CouseId)
RecipeId int 
    not null 
    foreign key references Recipe(RecipeId)
MainDish bit 
    not null
Constraint MealCourseId and RecipeId unique
*/

/*
Cookbook: 
CookbookId int
    not null
    identity
    primary key
CookbookName varchar(100)
    not null
    not '' 
    unique
Price decimal(5,2)
    not null
    must be above 0
CookbookPicture 
    computed as (tablename, -, CookbookName until space(, -, CookbookName after space))
UserId int 
    not null
    foreign key references User(UserId)
Active bit 
    not null
DateCreated date
    not null 
    must be after January 1, 2020
*/


/*
CookbookRecipe:
CookbookRecipeId int
    not null
    identity 
    primary key
CookbookId int 
    not null 
    foreign key references Cookbook(CookbookId)
RecipeId int
    not null
    foreign key references Recipe(RecipeId)
RecipeSequence int 
    not null
    must be above 0
Constraint RecipeId and RecipeSequence unique
*/