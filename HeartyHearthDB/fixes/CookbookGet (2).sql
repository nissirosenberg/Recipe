create or alter procedure dbo.CookbookGet(
	@CookbookId int = 0,
	@All bit = 0,
	@CookbookName varchar(100) = '',
	@IncludeBlank bit = 0
)
as
begin
	select @CookbookId = isnull(@CookbookId, 0), @CookbookName = isnull(@CookbookName, '')

	select c.CookbookId,
	c.UniqueCookbookId,
		   c.UserId,
		   c.CookbookName, 
		   u.UserName,
		   c.Price,
		   c.Active,
		   DateCreated = convert(varchar, c.DateCreated, 101),
		   c.CookbookSkill, 
		   c.CookbookSkillDesc,
		   c.CookbookPicture
	from Cookbook c 
	join Users u 
	on c.UserId = u.UserId
	where c.CookbookId = @CookbookId
	or @All = 1
	or c.CookbookName = @CookbookName
	union select 0,' ', 0, ' ', ' ', 0, convert(bit, 0), convert(date, ' '),0, ' ', ' '
	where @IncludeBlank = 1
	order by c.CookbookId

end
go
grant execute on CookbookGet to adminrole


