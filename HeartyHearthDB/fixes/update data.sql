update Recipe set Vegan = 1
where RecipeName like '%c%'
go
update Meal set MealDesc = concat('This is a meal called ', MealName)
go
update Cookbook set CookbookSkill = 1 
where CookbookName like '%m%'
go
update Cookbook set CookbookSkill = 3 
where CookbookName like '%k%'
go


select * from Recipe