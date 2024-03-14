create or alter procedure MealGet(
	@MealId int = 0,	
	@All bit = 0, 
	@MealName varchar(75) = '',
	@IncludeBlank bit = 0
	)
as 
begin
	select @MealName = nullif(@MealName, '')

	select m.MealId, m.UserId, u.UserName, m.MealName, m.Active, m.DateCreated, m.MealDesc
	from Meal m
	join Users u 
	on m.UserId = u.UserId
	where m.MealId = @MealId
	or @All = 1
	or m.MealName like '%' + @MealName + '%'
	union select 0,0, ' ',' ', convert(bit, 0), ' ', ' '
	where @IncludeBlank = 1
	order by m.MealId 
end
go

grant execute on MealGet to adminrole

