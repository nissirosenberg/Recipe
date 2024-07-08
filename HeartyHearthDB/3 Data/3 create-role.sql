use HeartyHearthDB
go


ALTER ROLE adminrole DROP MEMBER appadmin_user
go
drop role if exists adminrole
go
create role adminrole
go 
alter role adminrole add member appadmin_user
go

ALTER ROLE approle DROP MEMBER appadmin_user
go
drop role if exists approle
go 
create role approle
go
alter role approle add member appadmin_user


SELECT * FROM fn_my_permissions(NULL, 'DATABASE') WHERE subentity_name = 'appadmin_user';

SELECT
    prin.name AS principal_name,
    perm.permission_name,
    perm.state_desc AS permission_state,
    obj.name AS object_name
FROM
    sys.database_permissions AS perm
    JOIN sys.database_principals AS prin ON perm.grantee_principal_id = prin.principal_id
    LEFT JOIN sys.objects AS obj ON perm.major_id = obj.object_id
ORDER BY
    principal_name, object_name, permission_name;



--ALTER ROLE adminrole DROP MEMBER appadmin_user
