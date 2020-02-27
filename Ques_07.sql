
----------------------------------Inner JOIN ---------------------------------------------------------------------
select * from Stu_Details inner join Student_Details on Stu_Details.Student_ID = Student_Details.Student_ID

-------------------------------------------Left Join --------------------------------------------------------------
select * from Stu_Details left join Student_Details on Stu_Details.Student_ID = Student_Details.Student_ID

--------------------------------------------------Right Join -------------------------------------------------------------
select * from Stu_Details right join Student_Details on Stu_Details.Student_ID = Student_Details.Student_ID

------------------------------------------------Self Join -----------------------------------------------------------
select * from Student_Details as a join Student_Details as b on a.Student_ID = b.Student_ID

