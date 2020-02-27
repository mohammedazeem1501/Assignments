create table TBL_Employees
(
	Employee_ID int identity(1000,1) primary key,
	Employee_Name varchar (50) not null,
	DOB date,
	Contact_Number varchar(10) not null constraint verify check(Contact_Number like'[6-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	Salary money,
	Address varchar(80),
	ZIP_Code varchar(6) not null constraint verifyZIP check (ZIP_Code like '[0-9][0-9][0-9][0-9][0-9][0-9]'),
	Create_Date datetime2 default getdate(),
	Modify_Date datetime2,
	IsActive bit default 0
)

select * from TBL_Employees

insert into TBL_Employees(Employee_Name,DOB,Contact_Number,Salary,Address,ZIP_Code,IsActive) 
values('Azeem','1-15-1996','9560244072',NULL,'Yamuna Vihar, Delhi','110094',1)

insert into TBL_Employees(Employee_Name,DOB,Contact_Number,Salary,Address,ZIP_Code,IsActive) 
values('Arpit','1-15-1996','9888888888',NULL,'Gaur City, Noida','200008',1)

insert into TBL_Employees(Employee_Name,DOB,Contact_Number,Salary,Address,ZIP_Code,IsActive) 
values('Abhishek','1-15-1996','9888888888',NULL,'Sector 62, Noida','201301',1)

insert into TBL_Employees(Employee_Name,DOB,Contact_Number,Salary,Address,ZIP_Code,IsActive) 
values('Vishesh','1-15-1996','9888888888',NULL,'Dilshad garden, Delhi','201301',1)

insert into TBL_Employees(Employee_Name,DOB,Contact_Number,Salary,Address,ZIP_Code,IsActive) 
values('Vijay','1-15-1996','9888888888',NULL,'Akshardham, Delhi','201301',1)

insert into TBL_Employees(Employee_Name,DOB,Contact_Number,Salary,Address,ZIP_Code,IsActive) 
values('Neha','1-15-1996','9888888888',NULL,'Akshardham, Delhi','201301',1)


insert into TBL_Employees(Employee_Name,DOB,Contact_Number,Salary,Address,ZIP_Code,IsActive) 
values('Sonal','1-15-1996','9888888888',NULL,'Botanical Garden, Delhi','201301',1)

insert into TBL_Employees(Employee_Name,DOB,Contact_Number,Salary,Address,ZIP_Code,IsActive) 
values('Latika','1-15-1996','9888888888',NULL,'Janakpuri, Delhi','201301',1)

insert into TBL_Employees(Employee_Name,DOB,Contact_Number,Salary,Address,ZIP_Code,IsActive) 
values('Shagun','1-15-1996','9888888888',NULL,'Badarpur, Delhi','201301',1)

insert into TBL_Employees(Employee_Name,DOB,Contact_Number,Salary,Address,ZIP_Code,IsActive) 
values('Punita','1-15-1996','9888888888',NULL,'Faridabad, Delhi','201301',1)


create table Salary_Details
(
	Employee_ID int ,
	Month varchar(15),
	Salary money,
	foreign key (Employee_ID ) references TBL_Employees(Employee_ID)
)

select * from Salary_Details

select * from TBL_Employees

insert into Salary_Details
values(1010,'February',15100)

insert into Salary_Details
values(1010,'March',15100)

insert into Salary_Details
values(1010,'April',15100)

insert into Salary_Details
values(1010,'May',15100)

insert into Salary_Details
values(1010,'June',15100)

insert into Salary_Details
values(1010,'July',15100)

insert into Salary_Details
values(1010,'August',15100)



update TBL_Employees
set Emp.Salary = sal.Salary
from Emp inner join 
( select ID,SUM(Salary) as Salary from sal group by ID)
as sal on Emp.ID = sal.ID

update TBL_Employees
set TBL_Employees.Salary = Salary_Details.Salary
from TBL_Employees inner join
( select Employee_ID,SUM(Salary) as Salary from Salary_Details group by Employee_ID)
as Salary_Details on TBL_Employees.Employee_ID=Salary_Details.Employee_ID


select*from TBL_Employees


create function Update_Salary(@ID int) 
returns int as 
begin 
return
(select sum(Salary) from Salary_Details)
--update TBL_Employees 
--set TBL_Employees.Salary = Salary_Details.a
--from TBL_Employees inner join Salary_Details
--on TBL_Employees.Employee_ID=Salary_Details.Employee_ID
end

update TBL_Employees
set Salary = Update_Salary(101)

exec Update_Salary(102)

drop function Update_Salary



