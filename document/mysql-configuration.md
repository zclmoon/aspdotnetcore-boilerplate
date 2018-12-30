## Create DB User (please do not do this on your production)

CREATE USER 'mytest'@'localhost' IDENTIFIED BY '123456';

GRANT ALL ON my_test.* TO 'mytest'@'localhost';

## Initialize DB and DB Tables
Use ../db/DBSchema.sql for initializing test DB and DB tables

## VS Code extension for mysql
https://formulahendry.wordpress.com/2017/11/24/manage-mysql-in-visual-studio-code/