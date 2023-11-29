create or alter procedure dbo.MealListGet(
	@Message varchar(1000) = '' output
)
as
begin
	select  m.MealName, UserName = concat(u.UserFirstName, ' ', u.UserLastName), Calories = sum(r.calories), Courses = count(distinct c.CourseId), Recipes = count(r.RecipeId)--, mc.*,c.CourseName, r.RecipeName
	from Meal m 
	join MealCourse mc 
	on m.MealId = mc.MealId
	join Course c 
	on c.CourseId = mc.CourseId
	left join MealCourseRecipe mcr
	on mc.MealCourseId = mcr.MealCourseId
	left join Recipe r 
	on mcr.RecipeId = r.RecipeId
	left join Users u
	on u.UserId = m.UserId
	group by m.MealName, u.UserFirstName, u.UserLastName
	order by m.MealName
end
go


exec MealListGet