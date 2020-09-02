<Query Kind="Statements">
  <Reference Relative="..\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\Linqpad-Esst-2856085\source\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll</Reference>
</Query>

// Use Util.Snapshot method to 'snapshot' an object state.
// Useful to compare state of object as it changes 

var color = CourseLib.ColorSource.GetColors().ElementAt(132);
color.Dump();
var colorSnap = Util.Snapshot(color);

color.RedValue += 20;
color.GreenValue += 10;

Util.Dif(colorSnap, color).Dump();