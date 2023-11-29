create or alter procedure dbo.CuisineTypeUpdate(
	@CuisineTypeId int = 0,
	@CuisineTypeName varchar(35) = '',
	@Message varchar(1000) = '' output
)
as 
begin
	declare @return int = 0

	select @CuisineTypeId = isnull(@CuisineTypeId, 0), @CuisineTypeName = isnull(@CuisineTypeName,'')

	if @CuisineTypeId = 0
	begin
		insert CuisineType(CuisineTypeName)
		values(@CuisineTypeName)
		
		select @CuisineTypeId = SCOPE_IDENTITY()
	end
	else
	begin
		update CuisineType
		set
			CuisineTypeName = @CuisineTypeName
		where CuisineTypeId = @CuisineTypeId
	end

	return @return

	
end
go