--------------------------------------Function for table values---------------------

create function MyFunction (@ID int) 
returns table
as
return 
(select Student_ID, Grade from Student_Details where Student_ID = @ID)

-------------------------------Scalar valued function---------------------------
create function Another_Function (@ID int) 
returns varchar(10)
as
begin
return 
(select Grade from Student_Details where Student_ID = @ID)
end


select * from MyFunction(101)  -- invoking the table valued function

print dbo.Another_Function(101) -- invoking scalar valued function




