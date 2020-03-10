<Query Kind="Statements">
  <Connection>
    <ID>d8c678bd-792c-455f-a71e-a84a48bd2a0d</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Exercise</Database>
  </Connection>
</Query>

// Q6 (COUNT function)

var count =  TBL_Employees.Count(t => t.Employee_ID>1005);
Console.WriteLine("Count of the Employees : " + count);

//  (AVERAGE function)
var avg = TBL_Employees.Average(t => t.Salary);
Console.WriteLine("Average Salary of the Employees : " + avg);

//  (MAX function)
var max =  TBL_Employees.Max(t => t.Salary);
Console.WriteLine("Maximum Salary of an Employee : " + max);

//  (MIN function)
var min =  TBL_Employees.Min(t => t.Salary);
Console.WriteLine("Minimum Salary of an Employee : " + min);


