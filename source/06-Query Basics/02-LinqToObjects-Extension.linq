<Query Kind="Statements" />

// use LINQ query operators.
#region source
var colors = new List<string>
		{ "Green", "Blush", "Yellow",  "Red", "Orange", "Burgandy","Purple",
			 "White", "Black", "Blue" ,"Bronze"};

colors.Dump("Original List");
#endregion


// call with extension method syntax
var w = colors.Where(c => c.StartsWith("B"));

w.Dump("'Where' query operator - extension method");

var a = colors.Last().Dump("'Last' query operator - extension method");

// pipeline
var b = colors.Where(c => c.StartsWith("B")).First();
b.Dump("Pipeline");

// Learn more about LINQ 
// https://www.linkedin.com/learning/topics/linq