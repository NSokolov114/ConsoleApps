// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//var bd = new DateTime(2025, 4, 4, 12, 34, 56);

//Console.WriteLine(bd.DayOfYear); // 94

//var nextBd = bd.AddYears(1);

//Console.WriteLine(bd);

var rect1 = new Rectangle(5, 10);
Console.WriteLine($"Area is: {rect1.Width * rect1.Height}");


Console.ReadKey();

class Rectangle
{
    public int Width;
    public int Height;

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
}
