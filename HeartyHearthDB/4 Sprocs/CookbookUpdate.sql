create or alter procedure dbo.CookbookUpdate(
	@CookbookId int = 0 output, 
	@UserId int = 0,
	@CookbookName varchar(100) = '',
	@Price decimal(5,2) = 0,
	@Active bit = 0,
	@DateCreated date = '' output,
	@Message varchar(1000) = ''
	)
as
begin
	declare @return int = 0

	select @CookbookId = isnull(@CookbookId, 0), @UserId = isnull(@UserId, 0), @CookbookName = isnull(@CookbookName, ''), @Price = isnull(@Price, 0), @Active = isnull(@Active, 0), @DateCreated = isnull(@DateCreated, convert(varchar, getdate(), 101))

	if @CookbookId = 0
	begin
		insert Cookbook(UserId, CookbookName, Price, Active, DateCreated)
		values(@UserId, @CookbookName, @Price, @Active, @DateCreated)

		select @CookbookId = SCOPE_IDENTITY()
	end
	else
	begin
		update Cookbook
		set	
			UserId = @UserId,
			CookbookName = @CookbookName, 
			Price = @Price,
			Active = @Active,
			DateCreated = @DateCreated
		where CookbookId = @CookbookId
	end

	return @return
end
grant execute on CookbookUpdate to adminrole
