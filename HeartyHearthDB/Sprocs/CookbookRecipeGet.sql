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

	select cr.CookbookRecipeId, cr.CookbookId, cr.RecipeId, cr.RecipeSequence
	from CookbookRecipe cr
	where cr.CookbookId = @CookbookId
	or @All = 1
	order by cr.RecipeSequence

	return @return
end
go

use HeartyHearthDB
go
exec CookbookRecipeGet
@CookbookRecipeId = null,
@CookbookId = 9,
@All = null,
@Message = null