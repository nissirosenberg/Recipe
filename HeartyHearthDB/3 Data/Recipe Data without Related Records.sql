
;with x as (
	select RecipeName = 'Spicy Meat', CuisineTypeName = 'American', Calories = 300, UserName = 'BB23', DateDrafted = '2023-01-01 3:45', DatePublished = null, DateArchived = '2023-02-02 10:45'
	union select 'Spicy Chicken', 'English', 150, 'BB23', '2023-03-03 5:01', '2023-04-04 3:33', null
	union select 'Spicy Liver', 'English', 190, 'BB23', '2023-05-05 5:01', '2023-06-06 3:33', '2023-07-07 5:01'
)
insert Recipe(RecipeName, CuisineTypeId, Calories, UserId, DateDrafted, DatePublished, DateArchived)
select x.RecipeName, c.CuisineTypeId, x.Calories, u.UserId, x.DateDrafted, x.DatePublished, x.DateArchived
from x 
join CuisineType c 
on c.CuisineTypeName = x.CuisineTypeName
join Users u 
on x.UserName = u.UserName


