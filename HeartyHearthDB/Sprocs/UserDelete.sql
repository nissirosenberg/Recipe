create or alter procedure dbo.UserDelete(
		@UserId int = 0,
		@UserName varchar(50) = '',
		@Message varchar(1000) = ''

)
as
begin
	declare @return int = 0
	select @UserId = isnull(@UserId, 0), @UserName = isnull(@UserName, '')

	delete cr 
	--select *
	from recipe r 
	join CookbookRecipe cr 
	on r.RecipeId = cr.RecipeId
	join Users u 
	on r.UserId = u.UserId
	where u.UserId = @UserId
	
	delete cr 
	--select *
	from Users u 
	join Cookbook c 
	on u.UserId = c.UserId
	join CookbookRecipe cr 
	on c.CookbookId = cr.CookbookId
	where u.UserId = @UserId
	
	delete c 
	--select *
	from Users u 
	join Cookbook c 
	on c.UserId = u.UserId
	where u.UserId = @UserId
	
	delete mcr 
	--select *
	from MealCourseRecipe mcr 
	join Recipe r 
	on mcr.RecipeId = r.RecipeId
	join Users u 
	on u.UserId = r.UserId
	where u.UserId = @UserId
	
	delete mcr
	--select *
	from MealCourseRecipe mcr 
	join MealCourse mc 
	on mcr.MealCourseId = mc.MealCourseId
	join Meal m 
	on mc.MealId = m.MealId
	join Users u 
	on m.UserId = u.UserId
	where u.UserId = @UserId
	
	delete mc
	--select * 
	from MealCourse mc 
	join Meal m 
	on m.MealId = mc.MealId
	join Users u 
	on u.UserId = m.UserId
	where u.UserId = @UserId
	
	
	delete m 
	--select *
	from Meal m 
	join Users u 
	on m.UserId = u.UserId
	where u.UserId = @UserId
	
	delete rd 
	--select *
	from Users u 
	join Recipe r 
	on u.UserId = r.UserId
	join RecipeDirections rd 
	on r.RecipeId = rd.RecipeId
	where u.UserId = @UserId
	
	delete ri 
	--select *
	from Users u 
	join Recipe r 
	on u.UserId = r.UserId
	join RecipeIngredient ri 
	on r.RecipeId = ri.RecipeId
	where u.UserId = @UserId
	
	delete r 
	--select *
	from Recipe r 
	join Users u 
	on r.UserId = u.UserId
	where u.UserId = @UserId
	
	delete u
	--select *
	from Users u 
	where u.UserId = @UserId

	return @return
end
go