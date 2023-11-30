create or alter procedure dbo.CookbookRecipeUpdate(
		@CookbookRecipeId int = 0,
		@CookbookId int = 0,
		@RecipeId int = 0, 
		@RecipeSequence int = 0,
		@Message varchar(1000) = ''
)
as
begin
	declare @return int = 0
	select @CookbookRecipeId = isnull(@CookbookRecipeId, 0), @CookbookId = isnull(@CookbookId, 0), @RecipeId = isnull(@RecipeId, 0), @RecipeSequence = isnull(@RecipeSequence, 0)
	
	if @CookbookRecipeId = 0
	begin
		insert CookbookRecipe(CookbookId, RecipeId,RecipeSequence)
		values(@CookbookId, @RecipeId, @RecipeSequence)

		select @CookbookRecipeId = SCOPE_IDENTITY()
	end
	else
	begin
		update CookbookRecipe
		set	
			CookbookId = @CookbookId,
			RecipeId = @RecipeId,
			RecipeSequence = @RecipeSequence
		where CookbookRecipeId = @CookbookRecipeId
	end

	return @return
end
go
grant execute on CookbookRecipeUpdate to adminrole