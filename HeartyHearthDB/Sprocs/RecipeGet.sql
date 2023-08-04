create or alter procedure RecipeGet(@RecipeId int = 0, @All bit = 0, @RecipeName varchar(100) = '')
as 
begin
	select @RecipeName = nullif(@RecipeName, '')

	select r.RecipeId, r.UserId, r.CuisineTypeId, r.RecipeName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.CurrentStatus, r.RecipePicture
	from Recipe r 
	where r.RecipeId = @RecipeId
	or @All = 1
	or r.RecipeName like '%' + @RecipeName + '%'
end
go


/*
exec RecipeGet

declare @RecipeId int
select top 1 @RecipeId = r.RecipeId from Recipe r
exec RecipeGet @RecipeId = @RecipeId

exec RecipeGet @All = 1

exec RecipeGet @RecipeName = '' --return no results
exec RecipeGet @RecipeName = 'oo'
*/