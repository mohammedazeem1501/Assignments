create database LoginDB

create table form_data
(
	username varchar(30) not null,
	age int,
	pass varchar(15),
	c_pass varchar(15),
	email varchar(30)
)

select * from form_data
