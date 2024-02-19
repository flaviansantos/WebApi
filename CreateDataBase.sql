create database db_test

go

use db_test

go

create table Clients
(
  Id int not null identity(1,1) primary key,
  [Name] varchar(50),
  LastName varchar(100),
  Email varchar(255),
  DateRegister datetime,
  IsActive bit
)

go

create table Product
(
	Id int not null identity(1,1) primary key,
	[Name] varchar(100),
	ProductValue decimal(18,2),
	IsAvailable bit
)