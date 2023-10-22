create or alter procedure dbo.RecipeUpdate(
	@RecipeId int = 0 output,
	@UserId int = 0,
	@CuisineTypeId int = 0,
	@RecipeName varchar(100) = '',
	@Calories int = 0,
	@DateDrafted datetime = '',
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId,0), 
		   @UserId = isnull(@UserId, 0),
		   @CuisineTypeId = isnull(@CuisineTypeId, 0),
		   @RecipeName = isnull(@RecipeName, ''),
		   @Calories = isnull(@Calories, 0),
		   @DateDrafted = isnull(@DateDrafted, CURRENT_TIMESTAMP)



	if @RecipeId = 0
	begin
		insert Recipe(UserId, CuisineTypeId, RecipeName, Calories, DateDrafted)
		values(@UserId, @CuisineTypeId, @RecipeName, @Calories, @DateDrafted)

		select @RecipeId = SCOPE_IDENTITY()
	end
	else
	begin
		update Recipe
		set
			UserId = @UserId, 
			CuisineTypeId = @CuisineTypeId, 
			RecipeName = @RecipeName, 
			Calories = @Calories, 
			DateDrafted = @DateDrafted
		where RecipeId = @RecipeId
	end
	
	return @return
end
go