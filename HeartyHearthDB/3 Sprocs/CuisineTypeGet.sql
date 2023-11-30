create or alter procedure dbo.CuisineTypeGet(@CuisineTypeId int = 0, @All bit = 0, @CuisineTypeName varchar(35) = '', @IncludeBlank bit = 0)
as 
begin
	select @CuisineTypeName = nullif(@CuisineTypeName, ''), @IncludeBlank = isnull(@IncludeBlank, 0)

	select ct.CuisineTypeId, ct.CuisineTypeName
	from CuisineType ct 
	where ct.CuisineTypeId = @CuisineTypeId
	or @All = 1
	or ct.CuisineTypeName like '%' + @CuisineTypeName + '%'
	union select 0, ' '
	where @IncludeBlank = 1
	order by ct.CuisineTypeId
end 
go 
grant execute on CuisineTypeGet to adminrole
/*

declare @CuisineTypeId int 
select top 1 @CuisineTypeId = ct.CuisineTypeId from CuisineType ct
exec CuisineTypeGet @CuisineTypeId = @CuisineTypeId 

exec CuisineTypeGet @All = 1

exec CuisineTypeGet @CuisineTypeName = '' --return no results
exec CuisineTypeGet @CuisineTypeName = 'a'
*/