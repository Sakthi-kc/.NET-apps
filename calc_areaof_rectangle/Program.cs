using calc_areaof_rectangle;

string msg;

//Calculate area of Blade
Calc_Rectangle_Area AreaOfBlade = new Calc_Rectangle_Area()
{
    RectangleName = "Blade",
    Length = 26.5623M,
    Breadth = 10
};

msg = $"The area of the rectangle {AreaOfBlade.RectangleName} is {AreaOfBlade.Area()}";
Console.WriteLine(msg);


//Calculate area of Claude
Calc_Rectangle_Area AreaOfClaude = new Calc_Rectangle_Area()
{
    RectangleName = "Claude",
    Length = 15.2563M,
    Breadth = 15M
};

msg = $"The area of the rectangle {AreaOfClaude.RectangleName} is {AreaOfClaude.Area()}";
Console.WriteLine(msg);


//Calculate greater area
string GreaterArea = (AreaOfBlade.Area() == AreaOfClaude.Area()) ? "Both areas are equal" :
    ((AreaOfBlade.Area() > AreaOfClaude.Area()) ? "Blade is bigger" : "Claude is bigger");

Console.BackgroundColor = ConsoleColor.Gray;
Console.ForegroundColor = ConsoleColor.DarkGreen;

Console.WriteLine(GreaterArea);

Console.ResetColor();