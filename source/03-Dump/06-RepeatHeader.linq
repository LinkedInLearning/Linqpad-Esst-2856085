<Query Kind="Statements">
  <Reference Relative="..\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\Linqpad-Esst-2856085\source\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll</Reference>
</Query>

var q2 = from p in System.Diagnostics.Process.GetProcesses()
				 let ThreadCount = p.Threads.Count
				 orderby ThreadCount descending

				 select new {p.ProcessName, ThreadCount};
	q2.Dump (description:"Processor threads");
	
