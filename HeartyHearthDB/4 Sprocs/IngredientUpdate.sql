create or alter procedure dbo.IngredientUpdate(
	@IngredientId int = 0,
	@IngredientName varchar(40),
	@Message varchar(1000) = '' output
)
as
begin
	declare @return int = 0

	select @IngredientId = isnull(@IngredientId, 0), @IngredientName = isnull(@IngredientName, '')

	if @IngredientId = 0
	begin
		insert Ingredient(IngredientName)
		values(@IngredientName)

		select @IngredientId = SCOPE_IDENTITY()
	end
	else
	begin
		update Ingredient
			set
				IngredientName = @IngredientName
			where IngredientId = @IngredientId
	end

	return @return
end
go
grant execute on IngredientUpdate to adminrole