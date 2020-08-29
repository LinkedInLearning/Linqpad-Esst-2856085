<Query Kind="Statements" />

// A LINQ query with statements


// create the data source for LINQ to Objects
// a type that implements IEnumerable<T> (or an Array).
var oddNumbers = new List<long> { 9, 7, 5, 3, 1, -1, -3 - 5 };


// define the query
var q = from n in oddNumbers
								select n;
				
Console.WriteLine (q);	
				