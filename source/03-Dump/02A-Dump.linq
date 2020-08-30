<Query Kind="Statements" />

// Dump() is an extension method
// Outputs formatted data to the results window

// it chooses a format based on underlying type.

"hello".Dump(); 	// string literal
(20 > 10).Dump(); // boolean expression
27.9.Dump(); 			// double literal
27.9.ToString("C").Dump(); // ToString method
System.DateTime.Today.Dump();

