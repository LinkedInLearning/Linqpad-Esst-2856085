<Query Kind="Statements" />

// open an XML file and query contents.

#region "Load XML file"
var root = Path.GetDirectoryName (Util.CurrentQueryPath);
var xmlFilePath  = @"\Assets\RobotNames.xml";
var upPath = @"\..\" ;


// load the root element and children
var xmlTree = XElement.Load (root + upPath + xmlFilePath);
#endregion

var q = from allElements in xmlTree.Elements()
				 select allElements.Element("RobotName");


q.Dump();

var q2 = from allElements in xmlTree.Elements()
				 from a in allElements.Attributes() 
				 select a;
q2.Dump();