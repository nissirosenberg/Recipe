create or alter procedure dbo.AutoCreateACookbook(
	@CookbookId int = 0 output,
	@UserId int = 0,
	@Message varchar(1000) = '' output
)
as
begin
	declare @return int = 0
	select @CookbookId = isnull(@CookbookId, 0), @UserId = isnull(@UserId, 0)

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
		where tr.UserId = @UserId
		
		select @CookbookId = SCOPE_IDENTITY()
		
		insert CookbookRecipe(CookbookId, RecipeId, RecipeSequence)
		select c.CookbookId, r.RecipeId, row_number() over (order by r.RecipeName)
		from Users u 
		join Recipe r 
		on u.UserId = r.UserId
		join Cookbook c 
		on u.UserId = c.UserId
		where c.CookbookId = @CookbookId --c.CookbookName = concat('Recipes by ', u.UserFirstName, ' ', u.UserLastName)
		order by r.RecipeName
		
end
