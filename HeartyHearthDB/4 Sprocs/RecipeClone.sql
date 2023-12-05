create or alter procedure dbo.RecipeClone(
	@RecipeId int = null output,
	@BaseRecipeId int,
	@RecipeName varchar(30) = '', 
	@Message varchar(1000) = '' output
)
as 
begin
	declare @return int = 0

	

	insert Recipe(UserId, CuisineTypeId, RecipeName, Calories, DateDrafted, DatePublished, DateArchived)
	select r.UserId, r.CuisineTypeId, concat(r.RecipeName, ' - clone'), r.Calories, GETDATE(), null, null
	from Recipe r 
	where r.RecipeId = @BaseRecipeId
	

	 select @RecipeId = SCOPE_IDENTITY(); 

	 select @RecipeName = r.RecipeName 
	 from Recipe r 
	 where r.RecipeId = @RecipeId

	insert RecipeIngredient(RecipeId, Amount, MeasurementId, IngredientSequence, IngredientId)
	select @RecipeId, ri.Amount, ri.MeasurementId, ri.IngredientSequence, ri.IngredientId
	from Recipe r 
	join RecipeIngredient ri 
	on r.RecipeId = ri.RecipeId
	where r.RecipeId = @BaseRecipeId
	
	insert RecipeDirections(RecipeId, DirectionsSequence, Directions)
	select @RecipeId, rd.DirectionsSequence, rd.Directions
	from Recipe r 
	join RecipeDirections rd 
	on r.RecipeId = rd.RecipeId
	where r.RecipeId = @BaseRecipeId



return @return
end
go
grant execute on RecipeClone to adminrole



