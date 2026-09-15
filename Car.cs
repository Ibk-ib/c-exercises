using System;

public class Car
{
	public string Name { get; set; }
	public string Model { get; set; }
	public int Year { get; set; }
	public string Color { get; set; }


    public void DisplayCarInfo()
    {
        Console.WriteLine("Car Name: {0}", Name);
        Console.WriteLine("Car Model: {0}", Model);
        Console.WriteLine("Car Year: {0}", Year);
        Console.WriteLine("Car Color: {0}", Color);
    }

}
