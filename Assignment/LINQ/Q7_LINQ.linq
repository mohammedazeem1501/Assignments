<Query Kind="Expression">
  <Connection>
    <ID>d8c678bd-792c-455f-a71e-a84a48bd2a0d</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Exercise</Database>
  </Connection>
</Query>

//Q7 (Group BY )

from t in TBL_Employees
group t by t.ZIP_Code