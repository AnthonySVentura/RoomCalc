Console.WriteLine("Enter the length of the room?");
double Length = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the width of the room");
double Width = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the height of the room");
double Height = double.Parse(Console.ReadLine());
double Area = Width * Length;
double Perimeter = (Length * 2) + (Width * 2);
double Volume = Height * Width * Length;
double SurfaceArea = 2 * (Width * Length + Width * Height + Length * Height);

Console.WriteLine("The Area for the room is " + Area + " and your perimeter of the room will be " + Perimeter);

if (Area <= 250)
{
    Console.WriteLine("This is a small room");
}
else if (Area >= 650)
{
    Console.WriteLine("This is a large room");
}
else
{
    Console.WriteLine("This is a medium house");
}

Console.WriteLine("The volume of the room is " + Volume);

Console.WriteLine("The surface area of the room is " + SurfaceArea);