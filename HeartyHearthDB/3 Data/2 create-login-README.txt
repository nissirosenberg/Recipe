script to create login and user is excluded from this repo.
Create a file called create-login.sql (this file is ignored by git ignore in this repo)
Add the following to that file:

--Important note: create login in MASTER
create login [loginname] with password = '[password]'


--Important note: switch to target database
create user [username] from login [loginname]
