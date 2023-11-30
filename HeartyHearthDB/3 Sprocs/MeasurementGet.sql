create or alter procedure dbo.MeasurementGet(
	@MeasurementId int = 0,
	@MeasurementName varchar(35) = '',
	@All bit = 0,
	@Message varchar(1000) = '', 
	@IncludeBlank bit = 0
)
as
begin
	select @MeasurementId = isnull(@MeasurementId, 0), @MeasurementName = isnull(@MeasurementName, ' '), @All = isnull(@All, 1), @IncludeBlank = isnull(@IncludeBlank, 0)

	select m.MeasurementId, m.MeasurementName
	from Measurement m
	where m.MeasurementId = @MeasurementId
	or m.MeasurementName = @MeasurementName
	or @All = 1
	union select 0, ' '
	where @IncludeBlank = 1
	order by m.MeasurementId
end
go
grant execute on MeasurementGet to adminrole