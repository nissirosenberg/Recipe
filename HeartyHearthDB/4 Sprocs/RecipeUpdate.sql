create or alter procedure dbo.RecipeUpdate(
	@RecipeId int = 0 output,
	@UserId int = 0 output,
	@CuisineTypeId int = 0 output,
	@RecipeName varchar(100) = '',
	@Calories int = 0,
	@DateDrafted datetime = ''  output,
	@DatePublished datetime null = '' output,
	@DateArchived datetime null = '' output,
	@CurrentStatus varchar(25) = '' output,
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
		   @DateDrafted = isnull(@DateDrafted, convert(varchar, GETDATE(), 101)),
		   @CurrentStatus = isnull(@CurrentStatus, 'Draft')



	if @RecipeId = 0
	begin
		insert Recipe(UserId, CuisineTypeId, RecipeName, Calories, DateDrafted, DatePublished, DateArchived)
		values(@UserId, @CuisineTypeId, @RecipeName, @Calories, @DateDrafted, @DatePublished, @DateArchived)

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
			DateDrafted = @DateDrafted,
			DatePublished = @DatePublished, 
			DateArchived = @DateArchived
		where RecipeId = @RecipeId
	end
	
	return @return
end
go
grant execute on  RecipeUpdate to adminrole



