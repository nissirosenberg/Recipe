create or alter procedure dbo.CookbookListGet(
	@Message varchar(1000) = '' output
)
as 
begin

select c.CookbookName, Author = concat(u.UserFirstName, ' ', u.UserLastName), NumRecipes = count(distinct r.RecipeId),  c.Price
from Cookbook c
join Users u 
on c.UserId = u.UserId
join Recipe r 
on u.UserId = r.UserId
group by c.CookbookName, u.UserName, c.Price, u.UserFirstName, u.UserLastName
order by c.CookbookName

end
go

exec CookbookListGet