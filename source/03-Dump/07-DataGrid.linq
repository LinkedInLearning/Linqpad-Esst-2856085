<Query Kind="Statements">
  <Reference Relative="..\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\Linqpad-Esst-2856085\source\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll</Reference>
</Query>

var q = from wc in CourseLib.ColorSource.GetColors()
				
				select new {wc.ColorName, wc.HexValue, wc.RedValue, wc.GreenValue, wc.BlueValue	};
				
				
q.Dump();