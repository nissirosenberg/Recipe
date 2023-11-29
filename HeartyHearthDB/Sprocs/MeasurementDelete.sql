create or alter procedure dbo.MeasurementDelete(
	@MeasurementId int = 0,
	@Message varchar(1000) = '' output
)
as
begin
	declare @return int = 0
	select @MeasurementId = isnull(@MeasurementId, 0)

	delete Measurement where MeasurementId = @MeasurementId

	return @return

end
go