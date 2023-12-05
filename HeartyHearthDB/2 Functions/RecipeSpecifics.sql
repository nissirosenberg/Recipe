create or alter function dbo.RecipeSpecifics(@RecipeId int)
returns varchar(1000)
as
begin
	declare @value varchar(1000) = ''

	select @value = 
					concat(r.RecipeName, 
					' (', 
					ct.CuisineTypeName, 
					') has ', 
					count(distinct ri.RecipeIngredientId), 
					' ingredients and ',
					count(distinct rd.RecipeDirectionsId),
					' steps.'
					)
	from Recipe r 
	join CuisineType ct 
	on r.CuisineTypeId = ct.CuisineTypeId
	join RecipeIngredient ri
	on r.RecipeId = ri.RecipeId
	join RecipeDirections rd
	on r.RecipeId = rd.RecipeId
	where r.RecipeId = @RecipeId
	group by r.RecipeName, ct.CuisineTypeName
	




	return @value
end
go

select dbo.RecipeSpecifics(r.RecipeId) from Recipe r 