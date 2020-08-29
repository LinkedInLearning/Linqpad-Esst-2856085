<Query Kind="Program" />

void Main()
{
	var color = new WebColor();
	
	color.BlueValue = 125;
	color.GreenValue = 75;
	color.RedValue = 225;

	Console.WriteLine(color);


	Console.WriteLine(color.ToString());
}

// Define other methods, classes and namespaces here
public class WebColor
{
	public override string ToString()
	{
		return $"RGB (R:{this.RedValue} G:{this.GreenValue} B:{this.BlueValue})";
	}
	public string ColorName { get; set; }
	public string HexValue { get; set; }
	public Byte RedValue { get; set; }
	public Single RedPercent
	{
		get
		{
			return RedValue / 255.0F;
		}
	}

	public byte GreenValue { get; set; }
	public Single GreenPercent
	{
		get
		{
			return GreenValue / 255.0F;
		}
	}
	public byte BlueValue { get; set; }
	public Single BluePercent
	{

		get
		{
			return BlueValue / 255F;
		}
	}


}