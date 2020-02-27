create view [sample_view] as
select Student_ID from Student_Details

select * from sample_view

insert into sample_view 
values(107)

select * from Student_Details

delete from Student_Details where Student_ID = 107

-- we create views from a table as it works as snapshot from the table and we can further we can refer to the view to see the data and not from the table.

select Student_ID from sample_view 
where Student_ID between 102 and 105



