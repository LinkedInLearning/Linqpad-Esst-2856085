<Query Kind="Statements" />

// open an XML file and query contents.

#region "Load XML file"
var root = Path.GetDirectoryName (Util.CurrentQueryPath);
var xmlFilePath  = @"\Assets\RobotNames.xml";
var upPath = @"\..\" ;
var completePath = root + upPath + xmlFilePath;

// load the root element and children
var xmlTree = XElement.Load (completePath);
#endregion



var q = from allElements in xmlTree.Elements()
				 from allAttributes in allElements.Attributes() 
				 select allAttributes;
q.Dump();