<Query Kind="Statements">
  <Reference Relative="..\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\Linqpad-Esst-2856085\source\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll</Reference>
</Query>

// Output as HTML table

var q = from wc in CourseLib.ColorSource.GetColors()
				where wc.ColorFamily == CourseLib.ColorFamily.Orange
				select wc;
q.Dump();
