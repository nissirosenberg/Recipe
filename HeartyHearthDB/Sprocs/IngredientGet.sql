create or alter procedure dbo.IngredientGet(
	@IngredientId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0
)
as
begin
	select @IngredientId = isnull(@IncludeBlank, 0), @All = isnull(@All, 0), @IncludeBlank = isnull(@IncludeBlank, 0)

	select i.IngredientId, i.IngredientName
	from Ingredient i 
	where i.IngredientId = @IngredientId
	or @All = 1
	union select 0, ' '
	where @IncludeBlank = 1
	order by i.IngredientId
	
end
go


exec IngredientGet @All = 1, @IncludeBlank = 1

