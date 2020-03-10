<Query Kind="Expression">
  <Connection>
    <ID>d8c678bd-792c-455f-a71e-a84a48bd2a0d</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Exercise</Database>
  </Connection>
</Query>

// Q4 (inner join)

from t in TBL_Employees join s in Salary_Details on t.Employee_ID equals s.Employee_ID 
select new{t.Employee_ID,t.Employee_Name,s.Salary}




