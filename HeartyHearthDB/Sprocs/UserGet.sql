create or alter procedure dbo.UserGet(@UserId int = 0, @All bit = 0, @UserName varchar(50) = '')
as 
begin 
	select @UserName = nullif(@UserName, '')

	select u.UserFirstName, u.UserFirstName, u.UserLastName, u.UserName
	from Users u 
	where u.UserId = @UserId
	or @All = 1
	or u.UserName like '%' + @UserName + '%'
end
go

/*
exec UserGet

declare @UserId int
select top 1 @UserId = u.UserId from Users u
exec UserGet @UserId = @UserId

exec UserGet @All = 1

exec UserGet @UserName = '' --return no results
exec UserGet @UserName = 'a'
*/