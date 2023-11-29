create or alter procedure dbo.IngredientDelete(
	@IngredientId int = 0,
	@Message varchar(1000) = '' output
)
as
begin
	declare @return int = 0
	select @IngredientId = isnull(@IngredientId, 0)
	
	delete Ingredient where IngredientId = @IngredientId

	return @return

end
go