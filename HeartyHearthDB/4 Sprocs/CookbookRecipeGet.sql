create or alter procedure dbo.CookbookRecipeGet(
	@CookbookRecipeId int = 0 output,
	@CookbookId int = 0,
	@All bit = 0,
	@Message varchar(1000) = '' output
)
as
begin
	declare @return int = 0
	select @CookbookRecipeId = isnull(@CookbookRecipeId, 0), @CookbookId = isnull(@CookbookId, 0), @All = isnull(@All, 0)

	select cr.CookbookRecipeId, r.RecipeId, cr.CookbookId, r.RecipeName, r.CuisineTypeId, r.Calories, r.RecipePicture, r.UserId, u.UserName, r.DateDrafted, r.DatePublished, r.DateArchived, r.CurrentStatus, NumIngredients = count(ri.RecipeIngredientId), r.Vegan, cr.RecipeSequence
	from CookbookRecipe cr
	join Recipe r
	on r.RecipeId = cr.RecipeId
	join RecipeIngredient ri 
	on r.RecipeId = ri.RecipeId
	join Users u 
	on r.UserId = u.UserId
	where cr.CookbookId = @CookbookId
	or @All = 1
	group by cr.CookbookRecipeId, r.RecipeId, cr.CookbookId, r.RecipeName, r.CuisineTypeId, r.Calories, r.RecipePicture, r.UserId, u.UserName, r.DateDrafted, r.DatePublished, r.DateArchived, r.CurrentStatus, r.Vegan, cr.RecipeSequence
	order by cr.RecipeSequence

	return @return
end
go
grant execute on CookbookRecipeGet to adminrole
use HeartyHearthDB
go
exec CookbookRecipeGet
@CookbookRecipeId = null,
@CookbookId = 21,
@All = null,
@Message = null