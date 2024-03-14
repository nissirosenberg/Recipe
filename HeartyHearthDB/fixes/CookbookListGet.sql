create or alter procedure dbo.CookbookListGet(
	@Message varchar(1000) = '' output
)
as 
begin

select c.CookbookId, c.CookbookName, Author = concat(u.UserFirstName, ' ', u.UserLastName), NumRecipes = count(distinct r.RecipeId),  c.Price, c.CookbookSkill, c.CookbookSkillDesc
from Cookbook c
join Users u 
on c.UserId = u.UserId
join Recipe r 
on u.UserId = r.UserId
group by c.CookbookId, c.CookbookName, u.UserName, c.Price, u.UserFirstName, u.UserLastName, c.CookbookSkill, c.CookbookSkillDesc
order by c.CookbookName

end
go
grant execute on CookbookListGet to adminrole
--exec CookbookListGet