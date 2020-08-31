<Query Kind="Statements" />

var colors = new List<string> { "purple, orange, red, green, yellow, red, blue" };
colors.Dump("Colors");

var colorValues = new Dictionary<string, string>();

colorValues.Add("purple", "553311");
colorValues.Add("yellow", "FF63DD");

colorValues.Dump(description: "Keys and values");