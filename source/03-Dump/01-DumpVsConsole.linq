<Query Kind="Statements" />

// Console.Write, Console.WriteLine are familiar method
// LINQPad intercepts the output from these methods and 
// redirects it to the 'Results' panel.

// LinqPad converts the output to HTML for the results panel.

// Dump() is an LINQPad extension method/
// a better choice to output to results.

var greeting = "hello";

Console.WriteLine(greeting);

greeting.Dump();

".Dump() is easier to read, and has more customizable output".Dump();

