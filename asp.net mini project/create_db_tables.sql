-- Creating database
create database MindSpringDB;


-- Showing the databases
-- Shows only name and size
exec sp_databases;

-- or 

-- Showing more information about the databases
select * 
from sys.databases;


-- Choose the database else master database will be considered
Use MindSpringDB;


-- Creating admins table
create table admins(
	UserId bigint primary key identity,
	UserName varchar(50) not null,
	EmailId varchar(50) unique,
	Password varchar(50) not null
);

-- Unique will allow one null hence adding not null constraint to email
alter table admins
drop constraint UQ__admins__7ED91ACE8D341CD9;

alter table admins
alter column EmailId varchar(50) not null;

alter table admins
add constraint uk_email unique(EmailId);


-- Creating students_results table
create table students_results(
	StudentId bigint primary key identity,
	RollNumber varchar(50) not null unique,
	StudentName varchar(50) not null,
	Tamil int not null,
	English int not null,
	Maths int not null,
	Science int not null,
	SocialScience int not null,
	Total int not null
);


-- Showing tables
exec sp_tables;
--or
select *
from sys.tables;


-- Displaying tables
select * 
from admins;

select *
from students_results;

