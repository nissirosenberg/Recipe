create or alter procedure dbo.CourseUpdate(
	@CourseId int = 0,
	@CourseSequence int = 0,
	@CourseName varchar(75),
	@Message varchar(1000) = '' output
)
as
begin
	declare @return int = 0
	select @CourseId = isnull(@CourseId, 0), @CourseSequence = isnull(@CourseSequence, 0), @CourseName = isnull(@CourseName, '')

	if @CourseId = 0
	begin
		insert Course(CourseSequence, CourseName)
		values(@CourseSequence, @CourseName)

		select @CourseId = SCOPE_IDENTITY()
	end
	else
	begin
		update Course
			set
				CourseSequence = @CourseSequence,
				CourseName = @CourseName
			where CourseId = @CourseId
	end

	return @return
end
go

