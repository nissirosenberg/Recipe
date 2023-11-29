create or alter procedure dbo.RecipeListGet(
	@Message varchar(1000) = ''
)
as
begin

		select r.RecipeId, r.RecipeName, Status = r.CurrentStatus, u.UserName, r.Calories, NumIngredients = count(distinct ri.RecipeIngredientId)
		from Recipe r
		join Users u 
		on u.UserId = r.UserId
		left join RecipeIngredient ri
		on r.RecipeId = ri.RecipeId
		group by r.RecipeId, r.RecipeName, r.CurrentStatus, u.UserName, r.Calories
		order by (
				   case r.CurrentStatus
				   when 'Published' then 0
				   when 'Draft' then 1
				   when 'Archived' then 2
				   end)

end
go

