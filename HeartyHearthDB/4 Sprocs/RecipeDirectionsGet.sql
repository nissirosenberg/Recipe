create or alter procedure dbo.RecipeDirectionsGet(
	@RecipeDirectionsId int = 0,
	@RecipeId int = 0,
	@All bit = 0
)
as
begin
	declare @return int = 0

	select @RecipeDirectionsId = isnull(@RecipeDirectionsId, 0), @RecipeId = isnull(@RecipeId, 0), @All = isnull(@All, 0)

	select rd.RecipeDirectionsId, rd.RecipeId, rd.Directions,  rd.DirectionsSequence
	from RecipeDirections rd
	where rd.RecipeDirectionsId = @RecipeDirectionsId
	or rd.RecipeId = @RecipeId
	or @All = 1

	return @return
end
go

grant execute on RecipeDirectionsGet to adminrole