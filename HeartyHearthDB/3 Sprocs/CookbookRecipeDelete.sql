create or alter procedure dbo.CookbookRecipeDelete(
	@CookbookRecipeId int = 0 output,
	@Message varchar(1000) = '' output
)
as
begin
	declare @return int = 0
	select @CookbookRecipeId = isnull(@CookbookRecipeId, 0)

	delete CookbookRecipe where CookbookRecipeId = @CookbookRecipeId

	return @return
end
go
grant execute on CookbookRecipeDelete to adminrole