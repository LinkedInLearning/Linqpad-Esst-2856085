<Query Kind="Statements">
  <Reference Relative="..\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\Linqpad-Esst-2856085\source\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll</Reference>
</Query>

// Highlight data with Util.Highlight and Util.HighlightIF

var colors = CourseLib.ColorSource.GetColors()
.OrderBy(wc => wc.ColorName)

.Select(wc => new
{
	wc.ColorName,
	wc.HexValue,
	wc.RedPercent,
	wc.GreenPercent,
	wc.BluePercent
});
colors.Dump();



