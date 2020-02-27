----------------------My first procedure in which I'm updating a table...............

create procedure Invoked_Procedure
as
begin 
update Student_Details 
set Grade = 'C'
where Student_ID = '102'
end

---------------------------------Second procedure which is invoking the first procedure inside this procedure
create procedure My_Procedure
as
begin 
exec Invoked_Procedure
end

exec My_Procedure

select * from Student_Details