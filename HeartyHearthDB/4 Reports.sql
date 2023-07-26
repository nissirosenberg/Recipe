-- SM Excellent! See comments.
use HeartyHearthDB 
go 

--Home Page
--One resultset with number of recipes, meals, and cookbooks
select AmtOfRecipes = (select count(r.RecipeId) from Recipe r), 
       AmtOfMeals = (select Count(m.MealId) from Meal m), 
       AmtOfCookbooks = (select Count(c.CookbookId) from Cookbook c)

--Recipe list page:
--    List of all Recipes that are either published or archived, published recipes should appear at the top. 
--    In the resultset show the Recipe name with its status, dates it was published and archived (blank if not archived), user, number of calories and number of ingredients.
--	The recipe names of archived recipes should be displayed in gray on the website. In order to do that, the recipe names of archived recipes should be prefixed with <span style="color:gray"> and followed with </span>
--	Ex: Recipe name of archived Chocolate Chip Cookies should be <span style="color:gray">Chocolate Chip Cookies</span

select RecipeName = case r.CurrentStatus when 'Archived' then concat('<span style="color:gray">', r.RecipeName, '>/span' ) else r.RecipeName end , 
       r.CurrentStatus, 
       DatePublished = isnull(convert(varchar, r.DatePublished), ''), 
       DateArchived = isnull(convert(varchar, r.DateArchived), ''), 
       u.UserName, r.Calories, 
       AmtOfIngredients = count(ri.RecipeIngredientsId)
from Recipe r 
join Users u 
on r.UserId = u.UserId
join RecipeIngredients ri 
on r.RecipeId = ri.RecipeId
where r.CurrentStatus in ('Published', 'Archived')
group by r.RecipeName, r.CurrentStatus, r.DatePublished, DateArchived, u.UserName, r.Calories
order by r.CurrentStatus desc 

--Recipe details page:
--    Show for a specific (meaning choose one, and include the picture of it)  recipe (three result sets):
--        a) Recipe header: recipe name, number of calories, number of ingredients and number of steps.

select r.RecipeName, r.Calories, AmtOfIngredients = count(distinct ri.RecipeIngredientsId), AmtOfSteps = count(distinct rd.RecipeDirectionsId), r.RecipePicture
from Recipe r 
join RecipeIngredients ri 
on ri.RecipeId = r.RecipeId
join RecipeDirections rd 
on rd.RecipeId = r.RecipeId
where r.RecipeName = 'Cheese Bread'
group by r.RecipeName, r.Calories, r.RecipePicture

--        b) List of ingredients: show the measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
select ListOfIngredients = concat(cast(ri.Amount as float), ' ', m.MeasurementName, case  when m.MeasurementName is not null then ' ' else '' end, i.IngredientName)
from Recipe r 
join RecipeIngredients ri 
on ri.RecipeId = r.RecipeId
join Ingredient i 
on ri.IngredientId = i.IngredientId
left join Measurement m 
on ri.MeasurementId = m.MeasurementId
where r.RecipeName = 'Cheese Bread'
order by ri.IngredientSequence

--       c) List of prep steps sorted by sequence.
select rd.Directions
from Recipe r 
join RecipeDirections rd 
on r.RecipeId = rd.RecipeId
where r.RecipeName = 'Cheese Bread'
order by rd.DirectionsSequence

--Meal list page:
--    All active meals, meal name, user that created meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal

select m.MealName, u.UserName, CaloriesPerMeal = sum(r.Calories), AmtOfCourses = count(distinct mc.MealCourseId), AmtOfRecipes = count(distinct mcr.MealCourseRecipeId)
from Meal m 
join Users u 
on m.UserId = u.UserId
join MealCourse mc 
on m.MealId = mc.MealId
join MealCourseRecipe mcr 
on mc.MealCourseId = mcr.MealCourseId
join Recipe r 
on r.RecipeId = mcr.RecipeId
where m.Active = 1
group by m.MealName, u.UserName
order by m.MealName


--Meal details page:
--    Show for a specific (meaning choose one, and include the picture of it)  meal:
--        a) Meal header: meal name, user, date created.

select m.MealName, u.UserName, m.DateCreated 
from Meal m 
join Users u 
on m.UserId = u.UserId
where m.MealName = 'Breakfast Bash'

--        b) List of all recipes. 
--            Display in one column the course type, recipe, and for the main course show which dish is the main and which are side. 
--			In this format "Course Type: Main\Side dish - Recipe Name. Then main dishes should be bold, using the bold tags as shown below
--                ex: 
--                    Appetizer: Mixed Greens
--                    <b>Main: Main dish - Onion Pastrami Chicken</b>
--					Main: Side dish - Roasted cucumbers with mustard
select Recipes = concat(case  
                            when mcr.MainDish = 1 and c.CourseName = 'Main Course' then '<b>'
                            else ''
                            end,
                       c.CourseName, ': ',
                       case c.CourseName when 'Main Course' then concat
                            (case mcr.MainDish
                                 when 1 then 'Main Dish'
                                 else 'Side Dish'
                                 end, 
                            ' - ')
                            else ''
                            end,
                       r.RecipeName, 
                       case 
                            when mcr.MainDish = 1 and c.CourseName = 'Main Course' then '</b>'
                            else ''
                            end)
from Meal m 
join MealCourse mc 
on m.MealId = mc.MealId
join MealCourseRecipe mcr 
on mc.MealCourseId = mcr.MealCourseId
join Course c 
on mc.CourseId = c.CourseId
left join Recipe r 
on r.RecipeId = mcr.RecipeId
where m.MealName = 'Breakfast Bash'


--Cookbook list page:
--    Show all active cookbooks with author and number of recipes per book. Sorted by book name.

select c.CookbookName, u.UserName, RecipesPerBook = count(cr.RecipeId)
from Cookbook c
join Users u 
on c.UserId = u.UserId
join CookbookRecipe cr 
on c.CookbookId = cr.CookbookId 
where c.Active = 1
group by c.CookbookName, u.UserName
order by c.CookbookName


--Cookbook details page:
--    Show for specific (meaning choose one, and include the picture of it)  cookbook:
--    a) Cookbook header: cookbook name, user, date created, price, number of recipes.

select c.CookbookName, c.CookbookPicture, u.UserName, c.DateCreated, c.Price, RecipesPerBook =  count(cr.RecipeId) 
from Cookbook c 
join CookbookRecipe cr 
on c.CookbookId = cr.CookbookId
join Users u 
on u.UserId = c.UserId
where c.CookbookName = 'Just Sweet'
group by c.CookbookName, c.CookbookPicture, u.UserName, c.DateCreated, c.Price

--    b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  Note: User will click on recipe to see all ingredients and steps.

select cr.RecipeSequence, r.RecipeName, ct.CuisineTypeName, AmtOfIngredients = count(distinct IngredientId), AmtOfSteps = count(distinct rd.RecipeDirectionsId)
from Cookbook c 
join CookbookRecipe cr 
on c.CookbookId = cr.CookbookId
join Recipe r 
on r.RecipeId = cr.RecipeId
join CuisineType ct 
on ct.CuisineTypeId = r.CuisineTypeId
join RecipeIngredients ri 
on r.RecipeId = ri.RecipeId
join RecipeDirections rd 
on rd.RecipeId = r.RecipeId
where c.CookbookName = 'Just Sweet'
group by r.RecipeName, ct.CuisineTypeName, cr.RecipeSequence
order by cr.RecipeSequence

--April Fools Page:
--    On April 1st we have a page with a joke cookbook. For that page provide the following.
--    a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name proper cased. 
--            There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.

select distinct Recipes = concat(upper(substring(reverse(r.RecipeName), 1, 1)), substring(lower(reverse(r.RecipeName)), 2, 25)), 
                RecipePicture = concat('Recipe-', upper(substring(reverse(r.RecipeName), 1, 1)), lower(translate(substring(reverse(r.RecipeName), 2, 25), ' ', '-')), '.jpg')
from Recipe r 
join CookbookRecipe cr 
on r.RecipeId = cr.RecipeId


--    b) When the user clicks on a specific (meaning choose one, and include the picture of it)  
--            recipe they should see a list of the first ingredient of each recipe in the system, and a list of the last step in each recipe in the system

;with MaxDirectionSequence as(
        select DirectionsSequence = max(rd.DirectionsSequence), r.RecipeName
        from Recipe r 
        join RecipeIngredients ri 
        on r.RecipeId = ri.RecipeId
        join RecipeDirections rd 
        on r.RecipeId = rd.RecipeId
        where ri.IngredientSequence = 1
        group by r.RecipeName
 )
 select distinct rd.Directions
 from MaxDirectionSequence mds
 join Recipe r 
 on r.RecipeName = mds.RecipeName
 join RecipeDirections rd 
 on mds.DirectionsSequence = rd.DirectionsSequence
 and rd.RecipeId = r.RecipeId
 

--For site administration page:
----5 seperate reports
--    a) List of how many recipes each user created per status. Show 0 if none


select u.UserName, RecipesCreated = count(r.RecipeId), r.CurrentStatus
from Users u 
left join Recipe r 
on u.UserId = r.UserId
group by r.CurrentStatus, u.UserName


--	b) List of how many recipes each user created and average amount of days that it took for the user's recipes to be published.
select u.UserName, RecipesCreated = count(r.RecipeId), AvgDaysToPublish = avg(DATEDIFF(day, r.DateDrafted, r.DatePublished))
from Users u 
join Recipe r 
on u.UserId = r.UserId
group by u.UserName

--   c) For each user, show three columns: Total number of meals, Total Active meals, Total Inactive meals. Show 0 if none
--       Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
select u.UserName, 
       TotalNumberOfMeals = count(m.MealId), 
       TotalActiveMeals = sum(case m.Active when 1 then 1 else 0 end), 
       TotalInactiveMeals = sum(case m.Active when 0 then 1 else 0 end)
from Users u 
left join Meal m 
on u.UserId = m.UserId
group by u.UserName
 
--    d) For each user, show three columns: Total number of cookbooks, Total Active cookbooks, Total Inactive cookbooks. Show 0 if none
--        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
select 
       u.UserName, 
       TotalNumberOfCookbooks = count(c.CookbookId), 
       TotalActiveCookbooks = sum(case c.Active when 1 then 1 else 0 end),
       TotalInactiveCookbooks = sum(case c.Active when 0 then 1 else 0 end)
from Users u 
left join Cookbook c 
on u.UserId = c.UserId
group by u.UserName


--    e) List of archived recipes that were never published, and how long it took for them to be archived.
select r.RecipeName, HowLongItTookToPublish = datediff(day, r.DateDrafted, r.DateArchived)
from Recipe r 
where r.DatePublished is null 
and r.CurrentStatus = 'Archived'


--For user dashboard page:
--    a) For a specific user, show one result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
--        Tip: If you would like, you can use a CTE to get the User Id once instead of in each union select

;with UserName as (
       select u.UserId, u.UserName
       from Users u 
       where u.UserName = 'BB23'
)
select ProjectType = 'Recipes', TotalCreated = count(r.RecipeId)
from Recipe r 
join UserName un 
on r.UserId = un.UserId
union select 'Meals', count(distinct m.MealId)
from Meal m 
join UserName un 
on m.UserId = un.UserId
union select 'Cookbooks', count(distinct c.CookbookId)
from Cookbook c 
join UserName un 
on un.UserId = c.UserId

--    b) List of the user's recipes, display the status and the number of hours between the status it's in and the one before that. Omit recipes in drafted status.

select r.RecipeName, 
       HoursBetweenStatuses = datediff(hour,
                                       case r.CurrentStatus when 'Archived' then isnull(DatePublished, DateDrafted) else DateDrafted end,
                                       case r.CurrentStatus when 'Archived' then r.DateArchived else r.DatePublished end
       )                                     
from Recipe r 
join Users u 
on u.UserId = r.UserId
where r.CurrentStatus <> 'Draft'
and u.UserName = 'BB23'



--    OPTIONAL CHALLENGE QUESTION
--    c) Show a list of cuisines and the count of recipes the user has per cuisine, 0 if none
-- Hint: Start by writing a CTE to give you cuisines for which the user does have recipes. 
-- SM Excellent! +1 EC
;with x as (
       select ct.CuisineTypeName, u.UserId, u.UserName
       from CuisineType ct 
       left join Recipe r 
       on ct.CuisineTypeId = r.CuisineTypeId
       left join Users u 
       on u.UserId = r.UserId
)
select x.CuisineTypeName, RecipesPerCuisineType = count(case u.UserName when 'BB23' then u.UserId end)
from x 
left join Users u 
on x.UserName = u.UserName
group by x.CuisineTypeName















