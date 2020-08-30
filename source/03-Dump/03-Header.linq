<Query Kind="Statements" />

int x = 65;
bool isLargeNumber = x > 1000;
string isLargeResult = isLargeNumber ? "Large Number" : "Small number";

x.Dump();

//// add header
//x.Dump("X value");
//
//isLargeNumber.Dump ("isLargeNumber");
//
//isLargeResult.Dump("isLargeResult");