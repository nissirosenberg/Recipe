create or alter procedure dbo.RecipeDirectionsDelete(
	@RecipeDirectionsId int = 0,
	@Message varchar(1000) = '' output
)
as 
begin
	declare @return int = 0

	select @RecipeDirectionsId = isnull(@RecipeDirectionsId, 0)

	delete RecipeDirections where RecipeDirectionsId = @RecipeDirectionsId

	return @return
end
go
grant execute on  RecipeDirectionsDelete to adminrole