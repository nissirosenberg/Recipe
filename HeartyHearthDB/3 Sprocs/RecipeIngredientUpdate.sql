create or alter procedure dbo.RecipeIngredientUpdate(
	@RecipeIngredientId int = 0 output,
	@RecipeId int = 0,
	@MeasurementId int = 0,
	@IngredientId int = 0,
	@Amount int = 0,
	@IngredientSequence int = 0,
	@Message varchar(1000) = '' output
)
as 
begin
	declare @return int = 0

	select @RecipeIngredientId = isnull(@RecipeIngredientId, 0), 
	@RecipeId = isnull(@RecipeId, 0), 
	@MeasurementId = isnull(@MeasurementId, 0), 
	@IngredientId = isnull(@IngredientId, 0),
	@Amount = isnull(@Amount, 0),
	@IngredientSequence = isnull(@IngredientSequence, 0)

	if @RecipeIngredientId = 0
	begin
		insert RecipeIngredient(RecipeId, MeasurementId, IngredientId, Amount, IngredientSequence)
		values(@RecipeId, @MeasurementId, @IngredientId, @Amount, @IngredientSequence)
		
		select @RecipeIngredientId = SCOPE_IDENTITY()
	end
	else
	begin
		update RecipeIngredient
		set
			RecipeId = @RecipeId,
			MeasurementId = @MeasurementId,
			IngredientId = @IngredientId, 
			Amount = @Amount,
			IngredientSequence = @IngredientSequence
		where RecipeIngredientId = @RecipeIngredientId
	end

	return @return
end
go
grant execute on  RecipeIngredientUpdate to adminrole

