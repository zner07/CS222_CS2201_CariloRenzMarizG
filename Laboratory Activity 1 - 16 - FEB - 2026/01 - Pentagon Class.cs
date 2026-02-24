using System;

class Pentagon
{
    // Private field
    private double side;

    // Default constructor
    public Pentagon()
    {
        side = 0;
    }

    // Parameterized constructor
    public Pentagon(double s)
    {
        side = s;
    }

    // Method to get perimeter
    public double GetPerimeter()
    {
        return 5 * side;
    }

    // Method to get area
    public double GetArea()
    {
        return (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * side * side) / 4;
    }

    // Display method
    public void Display(string name)
    {
        Console.WriteLine(name);
        Console.WriteLine("--------------------------");
        Console.WriteLine("Side length: " + side);
        Console.WriteLine("Perimeter: " + GetPerimeter().ToString("F3"));
        Console.WriteLine("Area: " + GetArea().ToString("F3"));
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        // Using default constructor
        Pentagon p1 = new Pentagon();
        p1.Display("Pentagon p1");

        // Using parameterized constructor
        Pentagon p2 = new Pentagon(5);
        p2.Display("Pentagon p2");
    }
}
