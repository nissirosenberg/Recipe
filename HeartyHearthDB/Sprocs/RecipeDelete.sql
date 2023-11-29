create or alter procedure dbo.RecipeDelete(
	@RecipeId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0
	
	--if exists (select * from Recipe r where r.RecipeId = @RecipeId and (DATEDIFF(day, r.DateArchived, GETDATE()) <= 30 or r.CurrentStatus = 'Published'))
	--begin 
	--	select @return = 1, @Message = 'Can only delete recipe that is in draft or is archived for over 30 days.'
	--	goto finished
	--end

	begin try
		begin tran
		delete MealCourseRecipe where RecipeId = @RecipeId
		delete CookbookRecipe where RecipeId = @RecipeId
		delete RecipeDirections where RecipeId = @RecipeId
		delete RecipeIngredients where RecipeId = @RecipeId
		delete Recipe where RecipeId = @RecipeId

		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	finished:
	return @return
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

exec RecipeDelete
@RecipeId = 13,
@Message = null