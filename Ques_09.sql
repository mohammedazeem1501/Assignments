------------- where clause-----------------------   |   -------------having clause---------------------
--1. where clause can be used without groupBy.      |  1. having clause cannot be used wwithout groupBy.
--2. it selects rows before grouping.               |  2. it selects the rows after grouping.
--3. where clause cannot use aggregarte functions.  |  3. it can contain aggregate functions.


--------------------------------------------------------------------------------------------------------------------------------------

select * from TBL_Employees 
where Employee_ID = 1007

select avg(Salary),DOB from TBL_Employees
group By DOB
having avg(Salary)>10000






