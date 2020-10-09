<Query Kind="Statements">
  <Reference Relative="..\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\Linqpad-Esst-2856085\source\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll</Reference>
</Query>

// Running queries against real sources
// could suffer from latency issues and other delays.

// this example simulates a slow network

var colors = CourseLib.ColorSource.GetColorsSlow();


colors.Take(5).Dump();

// Use Util.Cache () to cache the data on first run.
//var colors = Util.Cache(CourseLib.ColorSource.GetColorsSlow,"myKey");