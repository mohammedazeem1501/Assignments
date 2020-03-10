<Query Kind="Statements">
  <Connection>
    <ID>d8c678bd-792c-455f-a71e-a84a48bd2a0d</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Exercise</Database>
  </Connection>
</Query>

// Q8 (First and FirstOrDefault)

//first (it will throw an error if the query fails to provide a result on the expression)
var first = TBL_Employees.First(t => t.Employee_ID==1001);
Console.WriteLine(first);

//first or deafult (it will handle the exception if there is no data found on this expression)
var second = TBL_Employees.FirstOrDefault(t => t.Employee_ID==1001);
Console.WriteLine(second);


