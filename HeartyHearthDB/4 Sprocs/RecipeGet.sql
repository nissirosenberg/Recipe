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
			u.UserName,
			r.CuisineTypeId, 
			r.RecipeName, 
			r.Calories, 
			DateDrafted = convert(datetime, r.DateDrafted, 101), 
			DatePublished = convert(datetime, r.DatePublished, 101), 
			DateArchived = convert(datetime, r.DateArchived, 101),  
			r.CurrentStatus, 
			r.RecipePicture,
			NumIngredients = count(ri.RecipeIngredientId),
			r.Vegan
	from Recipe r 
		join Users u 
	on r.UserId = u.UserId
	join RecipeIngredient ri
	on r.RecipeId = ri.RecipeId
	where r.RecipeId = @RecipeId

	or @All = 1
	or r.RecipeName like '%' + @RecipeName + '%'
	group by r.RecipeId, r.UserId, u.UserName, r.CuisineTypeId, r.RecipeName, r.Calories, r.DateDrafted,
	r.DatePublished, r.DateArchived, r.CurrentStatus, r.RecipePicture, r.Vegan
	union select 0, 0, ' ', 0, '', 0, '', '', '', '', '',0, convert(bit, 0)
	where @IncludeBlank = 1
	
	order by r.RecipeId 
end
go

grant execute on RecipeGet to adminrole
grant execute on RecipeGet to appadmin
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



