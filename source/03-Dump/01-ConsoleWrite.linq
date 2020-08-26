<Query Kind="Program" />

void Main()
{
	// a nice feature of LINQPad, it provides an easy way to output formatted content
	
	// no need to create a throwaway console app to experiment with code.
	// no need to clutter code with lots of Console.WriteLines help clarify output.
	
	var numbers = Enumerable.Range(1, 8);
	
	
	DrawTopLine ();
	foreach (var number in numbers)
	{
	//	Console.WriteLine("╠");
		if (number % 2 == 0)
		{
			//Console.WriteLine($"║ {number.ToString("D2")}:\t║ Is Even\t\t║");
			DrawDataLine (number, "Is Even");
		}
	
		else
		{
			//	Console.WriteLine($"║ {number.ToString("D2")}:\t║ Is Odd \t\t║");
				DrawDataLine (number, "Is Odd");
	
		}
		DrawDividerLine();
	}

DrawBottomLine();
}


// Define other methods, classes and namespaces here

public void DrawTopLine()
{
	Console.Write("╔");
	Console.Write(new string('═', 10));
Console.WriteLine("╗");
}
public void DrawBottomLine()
{
	Console.Write("╚");
	Console.Write(new string('═', 10));
	Console.WriteLine("╝");
}

public void DrawDividerLine()
{
	Console.Write("╠");
	Console.Write(new string('═', 10));
	Console.WriteLine("╣");
}

public void DrawDataLine(int number, string isOdd)
{
	
	Console.WriteLine($"║ {number.ToString("D2")}:\t║ {isOdd} {new string (' ',3)}║");
	//Console.Write(new string('═', 20));

}
