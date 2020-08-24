<Query Kind="Statements" />

// open an XML file and query contents.

var root = Path.GetDirectoryName (Util.CurrentQueryPath);
var xmlFilePath  = @"\Assets\RobotNames.xml";
var upPath = @"\..\" ;
root.Dump();

// load the root element and children
var xmlTree = XElement.Load (root + upPath + xmlFilePath);

xmlTree.Nodes().Dump();