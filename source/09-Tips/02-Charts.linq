<Query Kind="Statements">
  <Connection>
    <ID>54bf9502-9daf-4093-88e8-7177c129999f</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Provider>System.Data.SqlServerCe.4.0</Provider>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\DemoDB.sdf</AttachFileName>
    <Persist>true</Persist>
    <DeferDatabasePopulation>true</DeferDatabasePopulation>
  </Connection>
  <Reference Relative="..\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\Linqpad-Esst-2856085\source\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll</Reference>
</Query>

// Use chart to visualize data

var q = from p in Products
				orderby p.UnitsOnOrder descending
				select new {p.ProductID, p.ProductName, p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder};

q.Dump();			
//q.Chart(p => p.ProductName, p=>p.UnitsOnOrder  ).Dump();
 //q.Take(12).Chart(p => p.ProductName, p=>p.UnitsOnOrder ,Util.SeriesType.Spline ).Dump();