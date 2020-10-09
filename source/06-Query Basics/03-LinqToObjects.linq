<Query Kind="Statements" />

// Use Linq Query Expression

#region "source"
var colors = new List<string>
		{ "Green", "Blush", "Yellow",  "Red", "Orange", "Burgandy","Purple",
			 "White", "Black", "Blue" ,"Bronze"};
#endregion
// use a SQL like syntax to query
// converted to calls to LINQ Query Operators

var q = from x in colors
				where x.Length > 5
				orderby x
				select x;

q.Dump("More expressions");


// Learn more about LINQ 
// https://www.linkedin.com/learning/topics/linq