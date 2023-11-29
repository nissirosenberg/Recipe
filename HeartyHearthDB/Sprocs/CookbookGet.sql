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
		   c.UserId,
		   c.CookbookName, 
		   c.Price,
		   c.Active,
		   DateCreated = convert(varchar, c.DateCreated, 101),
		   c.CookbookPicture
	from Cookbook c 
	where c.CookbookId = @CookbookId
	or @All = 1
	or c.CookbookName = @CookbookName
	union select 0, 0, ' ', 0, 0, ' ', ' '
	where @IncludeBlank = 1
	order by c.CookbookId

end
go