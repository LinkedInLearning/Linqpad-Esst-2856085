<Query Kind="Statements" />

var colors = new List<string> { "purple", "orange", "red" };
colors.Dump("Colors List");

var colorValues = new Dictionary<string, string>();

colorValues.Add("purple", "553311");
colorValues.Add("yellow", "FF63DD");


colorValues.Dump("Key value pairs");