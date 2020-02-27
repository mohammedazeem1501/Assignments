select * from Student_Details


insert into Student_Details
values(101,'Azeem','Delhi', 'B', '7-7-2019')

insert into Student_Details
values(102,'Arpit','Delhi', 'A', '7-5-2020')

insert into Student_Details
values(103,'Ashish','Delhi', 'B', '7-3-2018')

insert into Student_Details
values(104,'Abhishek','Delhi', 'A', '7-7-2021')

insert into Student_Details
values(105,'Viay','Delhi', 'A', '1-15-2020')

select * from Student_Details


select Student_ID,Grade from Student_Details
where Date_Of_Addmission between '2018-07-07' and '2020-01-15'


