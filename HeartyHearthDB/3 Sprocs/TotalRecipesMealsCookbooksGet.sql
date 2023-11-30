create or alter procedure dbo.TotalRecipesMealsCookbooksGet(
	@Message varchar(1000) = '' output
	)
as
begin
	declare @return int = 0

				  select Category = 'Recipes', Amount = count(r.RecipeId) from Recipe r
		union select 'Meals', count(m.MealId) from Meal m
		union select 'Cookbooks', count(c.CookbookId) from Cookbook c
		
		return @return
			
end
go
grant execute on  TotalRecipesMealsCookbooksGet to adminrole
