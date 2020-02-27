-------------------------Proedure for updating the value
create procedure My_proc
as
begin 
update Student_Details 
set Grade = 'A'
where Student_ID = '103'
end


-----------------------------function for returning the value of the table by passing parameters
create function MyFunc (@ID int) 
returns table
as
return 
(select Student_ID, Grade from Student_Details where Student_ID = @ID)



--------------------------------Difference between procedures and functions

-----------function should return the values every time whether it is a table or any scalar value but the 
-----------procedures does not return the value every time...................................................................


exec My_proc

select * from MyFunction(101)