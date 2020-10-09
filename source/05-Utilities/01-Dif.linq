<Query Kind="Statements">
  <Reference Relative="..\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\Linqpad-Esst-2856085\source\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll</Reference>
</Query>


var color1= CourseLib.ColorSource.GetColors().ElementAt(0	);
var color2= CourseLib.ColorSource.GetColors().ElementAt(7);

Util.Dif(color1, color2 ).Dump();

