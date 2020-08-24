<Query Kind="Statements">
  <Connection>
    <ID>54bf9502-9daf-4093-88e8-7177c129999f</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Provider>System.Data.SqlServerCe.4.0</Provider>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\DemoDB.sdf</AttachFileName>
    <Persist>true</Persist>
  </Connection>
</Query>

// Use LINQ for query


var q = from p in Products
				where p.UnitPrice > 35
				orderby p.ProductName
				select new { p.ProductName, p.UnitPrice};
				
q.Dump();