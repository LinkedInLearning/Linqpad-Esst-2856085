<Query Kind="Statements" />

// open an XML file and query contents.

var root = Path.GetDirectoryName (Util.CurrentQueryPath);
var xmlFilePath  = @"\Assets\RobotNames.xml";
var upPath = @"\.." ;
var completePath = root + upPath + xmlFilePath;
completePath.Dump();

// load the root element and children
XElement xmlTree = XElement.Load (completePath);

xmlTree.Elements().Dump();