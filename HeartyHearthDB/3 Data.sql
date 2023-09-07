--use HeartyHearthDB
--go 

delete CookbookRecipe 
go 
delete Cookbook 
go 
delete MealCourseRecipe 
go 
delete MealCourse 
go 
delete Course 
go 
delete Meal 
go 
delete RecipeDirections
go 
delete RecipeIngredients
go
delete Recipe
go 
delete Users
go
delete Ingredient
go 
delete Measurement 
go 
delete CuisineType
go 

insert CuisineType(CuisineTypeName)
      select 'American'
union select 'French'
union select 'English'
union select 'Italian'

insert Measurement(MeasurementName)
      select 'Cup'
union select 'Cups'
union select 'Tsp'
union select 'Tsps'
union select 'Tbsp'
union select 'Tbsps'
union select 'Oz'
union select 'Pinch of'
union select 'Stick'
union select 'Sticks'
union select 'Heaping Tbsp'
union select 'Pack'

insert Ingredient(IngredientName)
      select  'Sugar'
union select  'Oil'
union select  'Egg'
union select  'Eggs'
union select  'Flour'
union select  'Vanilla Sugar'
union select  'Baking Powder'
union select  'Baking Soda'
union select  'Chocolate Chips'
union select  'Granny Smith Apples'
union select  'Vanilla Yogurt'
union select  'Orange Juice'
union select  'Honey'
union select  'Ice Cubes'
union select  'Club Bread'
union select  'Butter'
union select  'Shredded Cheese'
union select  'Cloves Garlic (Crushed)'
union select  'Black Pepper'
union select  'Salt'
union select  'Vanilla Pudding'
union select  'Whipped Cream Cheese'
union select  'Sour Cream Cheese'
union select 'Water'
union select 'Lemon Juice'
union select 'Cocoa'
union select 'Milk'
union select 'Jello'

insert Users(UserFirstName, UserLastName, UserName)
      select 'Allan', 'Amber', 'AA23'
union select 'Betty', 'Benner', 'BB23'
union select 'Carry', 'Cooker', 'CC23'


;with x as (
    select RecipeName = 'Chocolate Chip Cookies', CuisineTypeName = 'American', Calories = 130, UserName = 'AA23', DateDrafted = '2020-02-02 11:45', DatePublished = null, DateArchived = null
    union select 'Apple Yogurt Smoothie', 'French', 200, 'BB23', '2020-03-03 12:55', '2020-04-04 9:05', null 
    union select 'Cheese Bread', 'English', 250, 'CC23', '2020-05-05 11:00', '2020-06-06 15:06', '2020-07-07 12:50'
    union select 'Butter Muffins', 'American', 85, 'CC23', '2020-08-08 16:30', null, '2020-09-09 4:27'
    union select 'Lovely Lemonade', 'Italian', 30, 'AA23', '2022-01-01 12:00', null, null
    union select 'Hot Cocoa', 'French', 20, 'BB23', '2022-02-02 12:00', null, '2023-08-025 5:30'
    union select 'Jello Ices', 'American', 15, 'CC23', '2022-04-04 15:40', '2022-05-05 14:34', null
)
insert Recipe(RecipeName, CuisineTypeId, Calories, UserId, DateDrafted, DatePublished, DateArchived)
select x.RecipeName, ct.CuisineTypeId, x.Calories, u.UserId, x.DateDrafted, x.DatePublished, x.DateArchived
from x 
join CuisineType ct 
on x.CuisineTypeName = ct.CuisineTypeName
join Users u 
on x.UserName = u.UserName


;with x as (
            select RecipeName = 'Chocolate Chip Cookies', IngredientSequence = 1, Amount = 1, MeasurementName = 'Cup', IngredientName = 'Sugar'
      union select 'Chocolate Chip Cookies', 2, .5, 'Cup', 'Oil'
      union select 'Chocolate Chip Cookies', 3, 3, null, 'Eggs'
      union select 'Chocolate Chip Cookies', 4, 2, 'Cups', 'Flour'
      union select 'Chocolate Chip Cookies', 5, 1, 'Tsp', 'Vanilla Sugar'
      union select 'Chocolate Chip Cookies', 6, 2, 'Tsps', 'Baking Powder'
      union select 'Chocolate Chip Cookies', 7, .5, 'Tsp', 'Baking Soda'
      union select 'Chocolate Chip Cookies', 8, 1, 'Cup', 'Chocolate Chips'
      union select 'Apple Yogurt Smoothie', 1, 3, null, 'Granny Smith Apples'
      union select 'Apple Yogurt Smoothie', 2, 2, 'Cups', 'Vanilla Yogurt'
      union select 'Apple Yogurt Smoothie', 3, 2, 'Tsps', 'Sugar'
      union select 'Apple Yogurt Smoothie', 4, .5, 'Cup', 'Orange Juice'
      union select 'Apple Yogurt Smoothie', 5, 2, 'Tbsps', 'Honey'
      union select 'Apple Yogurt Smoothie', 6, 5, null, 'Ice Cubes'
      union select 'Cheese Bread', 1, 1, null, 'Club Bread'
      union select 'Cheese Bread', 2, 4, 'Oz', 'Butter'
      union select 'Cheese Bread', 3, 8, 'Oz', 'Shredded Cheese'
      union select 'Cheese Bread', 4, 2, null, 'Cloves Garlic (Crushed)'
      union select 'Cheese Bread', 5, .25, 'Tsp', 'Black Pepper'
      union select 'Cheese Bread', 6, 1, 'Pinch of', 'Salt'
      union select 'Butter Muffins', 1, 1, 'Stick', 'Butter'
      union select 'Butter Muffins', 2, 3, 'Cups', 'Sugar'
      union select 'Butter Muffins', 3, 2, 'Tbsps', 'Vanilla Pudding'
      union select 'Butter Muffins', 4, 4, null, 'Eggs'
      union select 'Butter Muffins', 5, 8, 'Oz', 'Whipped Cream Cheese'
      union select 'Butter Muffins', 6, 8, 'Oz', 'Sour Cream Cheese'
      union select 'Butter Muffins', 7, 1, 'Cup', 'Flour'
      union select 'Butter Muffins', 8, 2, 'Tsps', 'Baking Powder'
      union select 'Lovely Lemonade', 1, 4, 'Cups', 'Water'
      union select 'Lovely Lemonade', 2, 1, 'Cup', 'Sugar'
      union select 'Lovely Lemonade', 3, 1, 'Cup', 'Lemon Juice'
      union select 'Hot Cocoa', 1, 1, 'Cup', 'Water'
      union select 'Hot Cocoa', 2, 2, 'Tbsps', 'Sugar'
      union select 'Hot Cocoa', 3, 1, 'Heaping Tbsp', 'Cocoa'
      union select 'Hot Cocoa', 4, 1, 'Pinch of', 'Salt'
      union select 'Hot Cocoa', 5, 2, 'Oz', 'Milk'
      union select 'Jello Ices', 1, 1, 'Pack', 'Jello'
      union select 'Jello Ices', 2, 10, 'Cups', 'Water'
)
insert RecipeIngredients(RecipeId, Amount, MeasurementId, IngredientSequence, IngredientId)
select r.RecipeId, x.Amount, m.MeasurementId, x.IngredientSequence, i.IngredientId 
from x 
join Recipe r 
on x.RecipeName = r.RecipeName
join Ingredient i 
on x.IngredientName = i.IngredientName
left join Measurement m 
on x.MeasurementName = m.MeasurementName




;with x as (
            select DirectionsSequence =  1, Directions = 'Combine sugar, oil, and eggs in a bowl.'
      union select  2, 'Mix well.'
      union select  3, 'Add flour, vanilla sugar, baking powder, and baking soda.'
      union select  4, 'Beat for 5 minutes.'
      union select  5, 'Add chocolate chips'
      union select  6, 'Freeze for 1-2 hours.'
      union select  7, 'Roll into balls and place it spread out on a cookie sheet.'
      union select  8, 'Bake on 350 degrees for 10 minutes.'
)
insert RecipeDirections(RecipeId, DirectionsSequence, Directions)
select r.RecipeId, x.DirectionsSequence, x.Directions
from x 
cross join Recipe r 
where r.RecipeName = 'Chocolate Chip Cookies'


;with x as (
      select DirectionsSequence =  1, Directions = 'Peel the apples and dice.'
union select 2, 'Combine all ingredients in a bowl except for apples and ice cubes.'
union select 3, 'Mix until smooth.'
union select 4, 'Add apples and ice cubes.'
union select 5, 'Pour into glasses.'
)
insert RecipeDirections(RecipeId, DirectionsSequence, Directions)
select r.RecipeId, x.DirectionsSequence, x.Directions
from x 
cross join Recipe r 
where r.RecipeName = 'Apple Yogurt Smoothie'


;with x as (
      select DirectionsSequence =  1, Directions = 'Slit the bread every 3/4 inch.'
union select 2, 'Combine all ingredients in a bowl.'
union select 3, 'Fill slits with cheese mixture.'
union select 4, 'Wrap the bread into a foil and bake for 30 minutes.'
)
insert RecipeDirections(RecipeId, DirectionsSequence, Directions)
select r.RecipeId, x.DirectionsSequence, x.Directions
from x 
cross join Recipe r 
where r.RecipeName = 'Cheese Bread'


;with x as (
      select DirectionsSequence =  1, Directions = 'Cream butter with sugars.'
union select 2, 'Add eggs and mix well.'
union select 3, 'Slowly add the rest of the ingredients and mix well.'
union select 4, 'Fill the muffin pans 3/4 full and bake for 30 minutes.'
)
insert RecipeDirections(RecipeId, DirectionsSequence, Directions)
select r.RecipeId, x.DirectionsSequence, x.Directions
from x 
cross join Recipe r 
where r.RecipeName = 'Butter Muffins'


;with x as (
      select DirectionsSequence =  1, Directions = 'Boil water and sugar.'
union select 2, 'Add lemon juice.'
union select 3, 'Serve chilled.'
)
insert RecipeDirections(RecipeId, DirectionsSequence, Directions)
select r.RecipeId, x.DirectionsSequence, x.Directions
from x 
cross join Recipe r 
where r.RecipeName = 'Lovely Lemonade'


;with x as (
      select DirectionsSequence =  1, Directions = 'Boil water.'
union select 2, 'Add sugar, cocoa, and salt.'
union select 3, 'Add Milk.'
union select 4, 'Optional: Top with marshmallows.'
)
insert RecipeDirections(RecipeId, DirectionsSequence, Directions)
select r.RecipeId, x.DirectionsSequence, x.Directions
from x 
cross join Recipe r 
where r.RecipeName = 'Hot Cocoa'


;with x as (
      select DirectionsSequence =  1, Directions = 'Boil water and add jello.'
union select 2, 'Pour into 8 oz cups.'
union select 3, 'Freeze and enjoy.'
)
insert RecipeDirections(RecipeId, DirectionsSequence, Directions)
select r.RecipeId, x.DirectionsSequence, x.Directions
from x 
cross join Recipe r 
where r.RecipeName = 'Jello Ices'


;with x as (
            select MealName = 'Breakfast Bash', Active = 1, DateCreated = '2022-01-01'
      union select 'First Birthday Party', 1, '2022-01-01'
      union select 'Just Junk', 1, '2022-01-01'
      union select 'Betty''s Brunch', 0, '2022-06-06 13:09'
)
insert Meal(MealName, Active, DateCreated, UserId)
select x.MealName, x.Active, x.DateCreated, u.UserId
from x 
cross join Users u 
where u.UserName = 'BB23'


;with x as (
            select MealName = 'Light Supper', Active = 0, DateCreated = '2022-06-06'
      union select 'After School Snack', 0, '2022-06-06'
)
insert Meal(MealName, Active, DateCreated, UserId)
select x.MealName, x.Active, x.DateCreated, u.UserId
from x 
cross join Users u 
where u.UserName = 'AA23'



insert Course(CourseSequence, CourseName)
      select 1, 'Appetizer'
union select 2, 'Soup'
union select 3, 'Main Course'
union select 4, 'Dessert'

;with x as (
      select MealName = 'Breakfast Bash', CourseName = 'Appetizer'
      union select 'Breakfast Bash', 'Main Course'
      union select 'First Birthday Party', 'Appetizer'
      union select 'First Birthday Party', 'Dessert'
      union select 'Just Junk', 'Main Course'
      union select 'Light Supper', 'Appetizer'
      union select 'Light Supper', 'Main Course'
      union select 'Light Supper', 'Dessert'
      union select 'After School Snack', 'Main Course'
      union select 'Betty''s Brunch', 'Main'
      union select 'Betty''s Brunch', 'Dessert'
)
insert MealCourse(MealId, CourseId) 
select m.MealId, c.CourseId
from x 
join Meal m 
on x.MealName = m.MealName
join Course c 
on x.CourseName = c.CourseName

;with x as (
      select MealName = 'Breakfast Bash', CourseName = 'Main Course', RecipeName = 'Cheese Bread', MainDish = 1
      union select 'Breakfast Bash', 'Main Course', 'Butter Muffins', 0
      union select 'Breakfast Bash', 'Appetizer', 'Apple Yogurt Smoothie', 1
      union select 'First Birthday Party', 'Appetizer', 'Chocolate Chip Cookies', 1
      union select 'First Birthday Party', 'Appetizer', 'Apple Yogurt Smoothie', 0
      union select 'First Birthday Party', 'Dessert', 'Butter Muffins', 1
      union select 'Just Junk', 'Main Course', 'Chocolate Chip Cookies', 0
      union select 'Just Junk', 'Main Course', 'Butter Muffins', 1 
      union select 'Light Supper', 'Appetizer', 'Lovely Lemonade', 1
      union select 'Light Supper', 'Main Course', 'Cheese Bread', 1
      union select 'Light Supper', 'Main Course', 'Apple Yogurt Smoothie', 0
      union select 'Light Supper', 'Dessert', 'Jello Ices', 1
      union select 'Betty''s Brunch', 'Main Course', 'Cheese Bread', 1
      union select 'Betty''s Brunch', 'Dessert', 'Hot Cocoa', 1
)
insert MealCourseRecipe(MealCourseId, RecipeId, MainDish)
select mc.MealCourseId, r.RecipeId, x.MainDish
from x 
join Meal m 
on m.MealName = x.MealName
join Course c 
on c.CourseName = x.CourseName
join MealCourse mc 
on c.CourseId = mc.CourseId
and m.MealId = mc.MealId
join Recipe r 
on r.RecipeName = x.RecipeName


;with x as (
      select CookbookName = 'Treats for Two', Price = 30, UserName = 'AA23', Active = 1, DateCreated = '2020-10-10'
      union select 'Just Sweet', 12, 'AA23', 1, '2020-11-11'
      union select 'Almost Healthy', 10, 'BB23', 0, '2020-12-12'
      union select 'Drink it!', 15, 'CC23', 1, '2022-07-07'
      union select 'Random Collection', 10, 'CC23', 1, '2022-08-08'
      union select 'Have it Cold', 10, 'CC23', 0, '2022-09-09'
)
insert Cookbook(CookbookName, Price, UserId, Active, DateCreated)
select x.CookbookName, x.Price, u.UserId, x.Active, x.DateCreated
from x 
join Users u 
on x.UserName = u.UserName

;with x as (
            select CookbookName = 'Treats for Two', RecipeName = 'Chocolate Chip Cookies', RecipeSequence =  1
      union select 'Treats for Two', 'Apple Yogurt Smoothie', 2
      union select 'Treats for Two', 'Cheese Bread', 3
      union select 'Treats for Two', 'Butter Muffins', 4
      union select 'Just Sweet', 'Chocolate Chip Cookies', 1
      union select 'Just Sweet', 'Butter Muffins', 2
      union select 'Almost Healthy', 'Cheese Bread', 1
      union select 'Almost Healthy', 'Butter Muffins', 2
      union select 'Drink it!', 'Lovely Lemonade', 1
      union select 'Drink it!', 'Hot Cocoa', 2
      union select 'Drink it!', 'Apple Yogurt Smoothie', 3
      union select 'Random Collection', 'Chocolate Chip Cookies', 1
      union select 'Random Collection', 'Cheese Bread', 2
      union select 'Random Collection', 'Hot Cocoa', 3
      union select 'Have it Cold', 'Jello Ices', 1
      union select 'Have it Cold', 'Apple Yogurt Smoothie', 2
      union select 'Have it Cold', 'Lovely Lemonade', 3
)
insert CookbookRecipe(CookbookId, RecipeId, RecipeSequence)
select c.CookbookId, r.RecipeId, x.RecipeSequence
from x 
join Cookbook c 
on x.CookbookName = c.CookbookName
join Recipe r 
on x.RecipeName = r.RecipeName
