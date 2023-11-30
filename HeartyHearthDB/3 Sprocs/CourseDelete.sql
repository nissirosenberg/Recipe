create or alter procedure dbo.CourseDelete(
	@CourseId int = 0,
	@Message varchar(1000) = '' output
)
as
begin
	declare @return int = 0
	select @CourseId = isnull(@CourseId, 0)

	delete Course where CourseId = @CourseId

	return @return

end
go
grant execute on CourseDelete to adminrole