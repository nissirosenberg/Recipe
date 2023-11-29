-- SM Excellent! See comment.
--Note: some of these scripts are needed for specific items, when the instructions say "specific" pick one item in your data and specify it in the where clause using a unique value that identifies it, do not use the primary key.

--1) Sometimes when a staff member is fired. We need to eradicate everything from that user in our system. Write the SQL to delete a specific user and all the user's related records.

delete cr 
--select *
from recipe r 
join CookbookRecipe cr 
on r.RecipeId = cr.RecipeId
join Users u 
on r.UserId = u.UserId
where u.UserName = 'CC23'

delete cr 
--select *
from Users u 
join Cookbook c 
on u.UserId = c.UserId
join CookbookRecipe cr 
on c.CookbookId = cr.CookbookId
where u.UserName = 'CC23'

delete c 
--select *
from Users u 
join Cookbook c 
on c.UserId = u.UserId
where u.UserName = 'CC23'

delete mcr 
--select *
from MealCourseRecipe mcr 
join Recipe r 
on mcr.RecipeId = r.RecipeId
join Users u 
on u.UserId = r.UserId
where u.UserName = 'CC23'

delete mcr
--select *
from MealCourseRecipe mcr 
join MealCourse mc 
on mcr.MealCourseId = mc.MealCourseId
join Meal m 
on mc.MealId = m.MealId
join Users u 
on m.UserId = u.UserId
where u.UserName = 'CC23'

delete mc
--select * 
from MealCourse mc 
join Meal m 
on m.MealId = mc.MealId
join Users u 
on u.UserId = m.UserId
where u.UserName = 'CC23'


delete m 
--select *
from Meal m 
join Users u 
on m.UserId = u.UserId
where u.UserName = 'CC23'

delete rd 
--select *
from Users u 
join Recipe r 
on u.UserId = r.UserId
join RecipeDirections rd 
on r.RecipeId = rd.RecipeId
where u.UserName = 'CC23'

delete ri 
--select *
from Users u 
join Recipe r 
on u.UserId = r.UserId
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
where u.UserName = 'CC23'

delete r 
--select *
from Recipe r 
join Users u 
on r.UserId = u.UserId
where u.UserName = 'CC23'

delete u
--select *
from Users u 
where u.UserName = 'CC23'


--2) Sometimes we want to clone a recipe as a starting point and then edit it. For example we have a complex recipe (steps and ingredients) and want to make a modified version. 
--Write the SQL that clones a specific recipe, add " - clone" to its name.

insert Recipe(RecipeName, CuisineTypeId, Calories, UserId, DateDrafted, DatePublished, DateArchived)
select concat(r.RecipeName, ' - clone'), r.CuisineTypeId, r.Calories, r.UserId, getdate(), null, null 
from Recipe r 
where r.RecipeName = 'Butter Muffins'


insert RecipeIngredient(RecipeId, Amount, MeasurementId, IngredientSequence, IngredientId)
select (select r.RecipeId from Recipe r where r.RecipeName = concat('Butter Muffins', ' - clone')), ri.Amount, ri.MeasurementId, ri.IngredientSequence, ri.IngredientId
from Recipe r 
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
where r.RecipeName = 'Butter Muffins'

insert RecipeDirections(RecipeId, DirectionsSequence, Directions)
select (select r.RecipeId from Recipe r where r.RecipeName = concat('Butter Muffins', ' - clone')), rd.DirectionsSequence, rd.Directions
from Recipe r 
join RecipeDirections rd 
on r.RecipeId = rd.RecipeId
where r.RecipeName = 'Butter Muffins'


/*
3) We offer users an option to auto-create a recipe book containing all of their recipes. 
Write a SQL script that creates the book for a specific user and fills it with their recipes.
The name of the book should be Recipes by Firstname Lastname. 
The price should be the number of recipes multiplied by $1.33
Sequence the book by recipe name.

Tip: To get a unique sequential number for each row in the result set use the ROW_NUMBER() function. See Microsoft Docs.
	 The following can be a column in your select statement: Sequence = ROW_NUMBER() over (order by colum name) , replace column name with the name of the column that the row number should be sorted
*/
;with TotalRecipe as (
	select r.UserId, TotalRecipes = count(r.RecipeId)
	from Recipe r 
	group by r.UserId
)
insert Cookbook(CookbookName, Price, UserId, Active, DateCreated)
select concat('Recipes by ', u.UserFirstName, ' ', u.UserLastName), tr.TotalRecipes*1.33, tr.UserId, 1, getdate()
from TotalRecipe tr 
join Users u 
on tr.UserId = u.UserId
where u.UserName = 'CC23'

insert CookbookRecipe(CookbookId, RecipeId, RecipeSequence)
select c.CookbookId, r.RecipeId, row_number() over (order by r.RecipeName)
from Users u 
join Recipe r 
on u.UserId = r.UserId
join Cookbook c 
on u.UserId = c.UserId
where c.CookbookName = concat('Recipes by ', u.UserFirstName, ' ', u.UserLastName)
order by r.RecipeName


/*
4) Sometimes the calorie count of of an ingredient changes and we need to change the calorie total for all recipes that use that ingredient.
Our staff nutritionist will specify the amount to change per measurement type, and of course multiply the amount by the quantity of the ingredient.
For example, the calorie count for butter went down by 2 per ounce, and 10 per stick of butter. 
Write an update statement that changes the number of calories of a recipe for a specific ingredient. 
The statement should include at least two measurement types, like the example above. 
*/

--The calories went up 2 per oz of butter, and 8 per stick
update r 
set r.Calories = r.Calories + case m.MeasurementName
			when 'Oz' then 2
			when 'Stick' then 8
			when 'Sticks' then 8
			end * ri.Amount
from Ingredient i 
join RecipeIngredient ri 
on i.IngredientId = ri.IngredientId
join Measurement m 
on ri.MeasurementId = m.MeasurementId
join Recipe r 
on ri.RecipeId = r.RecipeId
where i.IngredientName = 'Butter'




/*
5) We need to send out alerts to users that have recipes sitting in draft longer the average amount of time that recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
	User First Name, 
	User Last Name, 
	email address (first initial + lastname@heartyhearth.com),
	Alert: 
		Your recipe [recipe name] is sitting in draft for [X] hours.
		That is [Z] hours more than the average [Y] hours all other recipes took to be published.
*/
;with AvgTimeToPublish as (
	select AvgTimeToPublish = avg(datediff(hour, r.DateDrafted, r.DatePublished))
	from Recipe r 
)
select u.UserFirstName, 
	   u.UserLastName, 
	   EmailAddress = concat(substring(u.UserFirstName, 1, 1), u.UserLastName, '@heartyhearth.com'), 
	   Alert = concat('Your recipe ', r.RecipeName, ' is sitting in draft for ', datediff(hour, r.DateDrafted, getdate()), ' hours.
 That is ', datediff(hour, r.DateDrafted, GETDATE()) - atp.AvgTimeToPublish, ' hours more than the average ', atp.AvgTimeToPublish, ' hours all other recipes took to be published.')
from Users u 
join Recipe r 
on u.UserId = r.UserId
join AvgTimeToPublish atp
on datediff(hour, r.DateDrafted, getdate()) > atp.AvgTimeToPublish
where r.CurrentStatus = 'Draft'


/*
6) We want to send out marketing emails for books. Produce a result set with one row and one column "Email Body" as specified below.
The email should have a unique guid link to follow, which should be shown in the format specified. 

Email Body:
Order cookbooks from HeartyHearth.com! We have [X] books for sale, average price is [Y]. You can order them all and recieve a 25% discount, for a total of [Z].
Click <a href = "www.heartyhearth.com/order/[GUID]">here</a> to order.
*/
select EmailBody = concat('Order cookbooks from HeartyHearth.com! We have ', count(c.CookbookId), ' books for sale, average price is ', convert(smallmoney, avg(c.Price)), '. 
You can order them all and recieve a 25% discount, for a total of ', convert(smallmoney, sum(c.Price)*.75), '. Click <a href = "www.heartyhearth.com/order/', Newid(), '">here</a> to order.')
from Cookbook c 


