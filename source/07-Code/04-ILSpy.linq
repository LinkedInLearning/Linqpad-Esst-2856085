<Query Kind="Statements">
  <Reference Relative="..\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\Linqpad-Esst-2856085\source\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll</Reference>
</Query>

// ILSpy is the open-source .NET assembly browser and decompiler.
// ILSpy is included in LINQPad
// Press F12 to decompile the source for a type or type-member.
// for any .NET assembly


var colors = CourseLib.ColorSource.GetColors();

var filtered = colors.Where(c =>c.GreenPercent <.25 );