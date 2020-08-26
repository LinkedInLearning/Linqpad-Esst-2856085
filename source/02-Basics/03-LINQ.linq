<Query Kind="Statements">
  <Reference Relative="..\..\..\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// A LINQ query with statements


// create the data source for LINQ to Objects
// a type that implements IEnumerable<T> (or an Array).
var oddNumbers = new List<long> { 9, 7, 5, 3, 1, -1, -3 - 5 };


// define the query
var q = from n in oddNumbers
				orderby n
				select n;
				
Console.WriteLine (q);	
				