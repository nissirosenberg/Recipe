create or alter procedure dbo.MeasurementUpdate(
	@MeasurementId int = 0,
	@MeasurementName varchar(30) = '',
	@Message varchar(1000) = '' output
)
as
begin
	declare @return int = 0
	select @MeasurementId = isnull(@MeasurementId, 0), @MeasurementName = isnull(@MeasurementName, '')

	if @MeasurementId = 0
	begin 
		insert Measurement(MeasurementName)
		values(@MeasurementName)

		select @MeasurementId = SCOPE_IDENTITY()
	end
	else 
	begin
		update Measurement 
			set
				MeasurementName = @MeasurementName
			where MeasurementId = @MeasurementId

	end

	return @return
end
go