create or alter procedure dbo.RecipeDirectionsUpdate(
	@RecipeDirectionsId int = 0 output, 
	@RecipeId int = 0, 
	@DirectionsSequence int = 0,
	@Directions varchar(500),
	@Message varchar(1000) = '' output
)
as 
begin
	declare @return int = 0

	select @RecipeDirectionsId = isnull(@RecipeDirectionsId, 0), 
	@RecipeId = isnull(@RecipeId, 0), 
	@DirectionsSequence = isnull(@DirectionsSequence, 0),
	@Directions = isnull(@Directions, '')

	
	if @RecipeDirectionsId = 0
	begin
		insert RecipeDirections( RecipeId, DirectionsSequence, Directions)
		values(@RecipeId, @DirectionsSequence, @Directions)

		select @RecipeDirectionsId = SCOPE_IDENTITY()
	end
	else
	begin
		update RecipeDirections
		set
			RecipeId = @RecipeId,
			DirectionsSequence = @DirectionsSequence,
			Directions = @Directions
		where RecipeDirectionsId = @RecipeDirectionsId
	end

	return @return
end
go
grant execute on RecipeDirectionsUpdate to adminrole
--use HeartyHearthDB
--go
--exec 
--@RecipeDirectionsId = 32,
--@RecipeId = 11,
--@DirectionsSequence = null,
--@Directions = 'Combine sugar, oil, and eggs in a pan.',
--@Message = null
