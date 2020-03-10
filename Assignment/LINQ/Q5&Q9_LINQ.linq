<Query Kind="Expression">
  <Connection>
    <ID>d8c678bd-792c-455f-a71e-a84a48bd2a0d</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Exercise</Database>
  </Connection>
</Query>

//Q5 (left join)

//Q9 is also implemented here only as it says to show the functionality of the DefaultIfEmpty().....!!


from t in TBL_Employees join s in Salary_Details on t.Employee_ID equals s.Employee_ID into ts
from s in ts.DefaultIfEmpty() 
select new{t.Employee_ID,t.Employee_Name,s.Salary}
