create or alter procedure RecipeGet(
	@RecipeId int = 0,	
	@All bit = 0, 
	@RecipeName varchar(100) = '',
	@CurrentStatus varchar(9) = '' output,
	@IncludeBlank bit = 0
	)
as 
begin
	select @RecipeName = nullif(@RecipeName, '')

	select r.RecipeId, 
			r.UserId, 
			r.CuisineTypeId, 
			r.RecipeName, 
			r.Calories, 
			DateDrafted = convert(varchar, r.DateDrafted, 101), 
			DatePublished = convert(varchar, r.DatePublished, 101), 
			DateArchived = convert(varchar, r.DateArchived, 101),  
			r.CurrentStatus, 
			r.RecipePicture
	from Recipe r 
	where r.RecipeId = @RecipeId
	or @All = 1
	or r.RecipeName like '%' + @RecipeName + '%'
	union select 0, 0, 0, '', 0, '', '', '', '', ''
	where @IncludeBlank = 1
	order by r.RecipeId 
end
go

grant execute on RecipeGet to adminrole
/*
exec RecipeGet

declare @RecipeId int
select top 1 @RecipeId = r.RecipeId from Recipe r
exec RecipeGet @RecipeId = @RecipeId
exec RecipeGet

exec RecipeGet @All = 1

exec RecipeGet @RecipeName = '' --return no results
exec RecipeGet @RecipeName = 'oo'
*/



