<Query Kind="Statements">
  <Reference Relative="..\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\Linqpad-Esst-2856085\source\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll</Reference>
</Query>

// To display data side-by-side, use Util.HorizontalRun:

var colors = CourseLib.ColorSource.GetColors()
.OrderBy(wc => wc.ColorName)
.Select(wc => new
{
	wc.ColorName,
	BluePercent = wc.BluePercent.ToString("P0")
});

var firstBatch = colors.Take(4);
var nextBatch = colors.Skip(20).Take(4);
//firstBatch.Dump();
//nextBatch.Dump();
Util.HorizontalRun(false, firstBatch, nextBatch).Dump();
