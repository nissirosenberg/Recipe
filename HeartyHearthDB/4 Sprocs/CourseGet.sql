create or alter procedure dbo.CourseGet( 
	@CourseId int = 0,
	@CourseSequence int = 0,
	@CourseName varchar(75) = '',
	@All bit = 0,
	@Message varchar(1000) = '',
	@IncludeBlank bit = 0
)
as 
begin

	select @CourseId = isnull(@CourseId, 0), @CourseSequence = isnull(@CourseSequence, 0), @CourseName = isnull(@CourseName, '')

	select c.CourseId, c.CourseSequence, c.CourseName
	from Course c 
	where c.CourseId = @CourseId
	or c.CourseSequence = @CourseSequence
	or c.CourseName = @CourseName
	or @All = 1
	union select  0, 0, ' '
	where @IncludeBlank = 1
	order by c.CourseId
end
go
grant execute on CourseGet to adminrole
--exec CourseGet @All = 1