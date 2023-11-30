create or alter procedure dbo.UserUpdate(
	@UserId int = 0,
	@UserFirstName varchar(40) = '',
	@UserLastName varchar(40) = '',
	@UserName varchar(50) = '',
	@Message varchar(1000) = '' output
)
as
begin
	declare @return int = 0

	select @UserId = isnull(@UserId, 0), @UserFirstName = isnull(@UserFirstName, ''), @UserLastName = isnull(@UserLastName, ''), @UserName = isnull(@UserName, '')

	if @UserId = 0
	begin
		insert Users(UserFirstName, UserLastName, UserName)
		values(@UserFirstName, @UserLastName, @UserName)

		select @UserId = SCOPE_IDENTITY()
	end
	else
	begin
		update Users	
		set	
			UserFirstName = @UserFirstName,
			UserLastName = @UserLastName,
			UserName = @UserName
		where UserId = @UserId
	end

	return @return

end
go
grant execute on UserUpdate to adminrole
go
