create or alter procedure dbo.RecipeIngredientDelete(
	@RecipeIngredientId int = 0,
	@Message varchar(1000) = '' output
)
as
begin

	declare @return int = 0

	select @RecipeIngredientId = isnull(@RecipeIngredientId, 0)

	delete RecipeIngredient where RecipeIngredientId = @RecipeIngredientId

	return @return

end
go
grant execute on RecipeIngredientDelete to adminrole