create or alter procedure dbo.IngredientGet(
	@IngredientId int = 0,
	@IngredientName varchar(40) = '',
	@All bit = 0,
	@IncludeBlank bit = 0
)
as
begin
	select @IngredientId = isnull(@IncludeBlank, 0), @IngredientName = isnull(@IngredientName, ''),  @All = isnull(@All, 0), @IncludeBlank = isnull(@IncludeBlank, 0)

	select i.IngredientId, i.IngredientName
	from Ingredient i 
	where i.IngredientId = @IngredientId
	or i.IngredientId like '%' + @IngredientId + '%'
	or @All = 1
	union select 0, ' '
	where @IncludeBlank = 1
	order by i.IngredientId
	
end
go

grant execute on IngredientGet to adminrole
--exec IngredientGet @All = 1, @IncludeBlank = 1

