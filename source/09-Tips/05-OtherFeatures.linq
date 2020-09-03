<Query Kind="Statements">
  <Namespace>System.Numerics</Namespace>
</Query>

// There is more to see in LINQPad


// UI controls, useful for interactive queries.
// Regex editor (ctrl-shift-f1)
// ^\d+$


Regex.Matches ("1234", @"^\d+$", RegexOptions.None).Dump();
