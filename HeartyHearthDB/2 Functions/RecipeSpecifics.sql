create or alter function dbo.RecipeSpecifics(@RecipeId int)
returns varchar(1000)
as
begin
	declare @value varchar(1000) = ''
	
	select @value = concat(
	(select r.RecipeName from Recipe r where r.RecipeId = @RecipeId),
	' (',
	(select ct.CuisineTypeName from Recipe r join CuisineType ct on r.CuisineTypeId = ct.CuisineTypeId where r.RecipeId = @RecipeId),
	') has ',
	(select count(ri.RecipeIngredientsId) from Recipe r join RecipeIngredients ri on r.RecipeId = ri.RecipeId where r.RecipeId = @RecipeId),
	' ingredients and ',
	(select count(rd.RecipeDirectionsId) from Recipe r join RecipeDirections rd on r.RecipeId = rd.RecipeId where r.RecipeId = @RecipeId),
	' steps.'
	) 



	return @value
end
go

select dbo.RecipeSpecifics(r.RecipeId), * from Recipe r 