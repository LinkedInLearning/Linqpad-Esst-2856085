<Query Kind="Statements">
  <Reference Relative="..\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\Linqpad-Esst-2856085\source\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll</Reference>
</Query>

// Add custom extension methods to LINQPAD
// Write the code in the 'My Extensions' tab.

var colors = CourseLib.ColorSource.GetColors();

colors.Skip(7).Take(4).Select(c => c.ColorName ).Dump();



//colors.Skip(7).Take(4).Select(c => c.ColorName ).MakeDelimitedString().Dump();