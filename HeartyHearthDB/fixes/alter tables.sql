alter table Recipe add Vegan bit not null default 0
go
alter table Meal add MealDesc varchar(1000) not null default ''
go
alter table Cookbook add CookbookSkill int not null default 1
	constraint c_Cookbook_Cookbook_skill_must_be_1_2_or_3 check(CookbookSkill between 0 and 3)
go
alter table Cookbook add CookbookSkillDesc as case
	when CookbookSkill = 1 then 'Beginner'
	when CookbookSkill = 2 then 'Intermediate'
	when CookbookSkill = 3 then 'Advanced'
	end persisted
go
alter table Cookbook add UniqueCookbookId as concat(CookbookName, Price, CookbookSkill, UserId)
go

select * from Cookbook

select * from recipe