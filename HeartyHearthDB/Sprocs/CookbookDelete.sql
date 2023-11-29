create or alter procedure dbo.CookbookDelete(
	@CookbookId int = 0,
	@Message varchar(1000) = ''

)
as
begin
	declare @return int = 0
	select @CookbookId = isnull(@CookbookId, 0)
	begin try
		begin tran
			delete CookbookRecipe where CookbookId = @CookbookId
			delete Cookbook where CookbookId = @CookbookId
		commit
	end try
	begin catch
		rollback;
	end catch

	finished:
	return @return

	return @return
end
go