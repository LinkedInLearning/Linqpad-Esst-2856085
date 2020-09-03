<Query Kind="Program">
  <Namespace>System.Numerics</Namespace>
</Query>

// From the LINQPad samples

void Main()
{
	// Accessing an object's private fields, properties and methods 
	// is useful for diagnostics and debugging.
	// LINQPad's Uncapsulate() extension method lets you do this without messing with Reflection.

	var demo = new Demo();
	int privateValue = demo.Uncapsulate()._private;    // Much easier than using reflection!
	privateValue.Dump("Access private members!");

	demo.Uncapsulate().DivideThis(2.5).Dump("Call private members");

	// Unencapsulate() works by returning a dynamic object that 
	//implements IDynamicMetaObjectProvider.
	// This dynamic proxy makes all of the Reflection calls for you.
}

class Demo
{
	int _private = 123;
	double _privateDouble = 150.50;
	private double DivideThis(double divisor)

	{
		return _privateDouble / divisor;
	}
}