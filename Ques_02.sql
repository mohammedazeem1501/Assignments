------------------------------creating a table for performing the questions ---------------------------------
create table Student_Details
(
	Student_ID int primary key,
	Student_First_Name varchar(30),
	Address varchar(50),
	Grade varchar(1) 
)

-------------------------------------renaming the column from Student First name to Student.Name and Adress to Student_add
sp_rename 'Student_Details.Address','Student_Add'

sp_rename 'Student_Details.Student_First_Name','Student_Name'

select * from Student_Details
	
