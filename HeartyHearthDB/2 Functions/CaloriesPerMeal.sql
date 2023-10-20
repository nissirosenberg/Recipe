create or alter function dbo.CaloriesPerMeal(@MealId int)
returns int
as
begin
	declare @value int = 0

		select @value =  sum(r.Calories) 
		from Meal m
		join Users u 
		on u.UserId = m.UserId
		join Recipe r 
		on r.UserId = u.UserId
		where m.MealId = @MealId
		group by m.MealId, m.MealName

	return @value
end
go

select CaloriesPerMeal = dbo.CaloriesPerMeal(m.MealId), m.*
from Meal m


