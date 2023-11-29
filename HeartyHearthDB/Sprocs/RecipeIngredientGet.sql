create or alter procedure dbo.RecipeIngredientGet(
	@RecipeIngredientId int = 0,
	@RecipeId int = 0,
	@All bit = 0,
	@Message varchar(1000) = '' output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All, 0), @RecipeIngredientId = isnull(@RecipeIngredientId, 0), @RecipeId = isnull(@RecipeId, 0)

	select ri.RecipeIngredientId, ri.IngredientId, ri.RecipeId,  ri.MeasurementId, ri.Amount, ri.IngredientSequence
	from RecipeIngredient ri
	where @All = 1
	or ri.RecipeId = @RecipeId

	return @return

	
end
go


