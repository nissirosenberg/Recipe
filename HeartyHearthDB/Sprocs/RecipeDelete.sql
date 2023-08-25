create or alter procedure dbo.RecipeDelete(
	@RecipeId int --= 0
)
as
begin
	begin try
		begin tran
		delete RecipeDirections where RecipeId = @RecipeId
		delete RecipeIngredients where RecipeId = @RecipeId
		delete Recipe where RecipeId = @RecipeId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch
end
go

/*
declare @recipeid int

select @recipeid = r.RecipeId
from Recipe r 

select * 
from Recipe r 
where r.RecipeId = @recipeid

exec RecipeDelete @RecipeId = @recipeid

select * 
from Recipe r 
where r.RecipeId = @recipeid
*/