create or alter procedure dbo.CuisineTypeDelete(
	@CuisineTypeId int = 0,
	@Message varchar(1000) = '' output
)
as
begin
	declare @return int = 0

	select @CuisineTypeId = isnull(@CuisineTypeId, 0)

	delete CuisineType where CuisineTypeId = @CuisineTypeId

	return @return

end
go
grant execute on CuisineTypeDelete to adminrole

