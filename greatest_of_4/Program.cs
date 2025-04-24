using greatest_of_4;

//Calling Greatest function

Find_Greatest greatest = new Find_Greatest()
{
    FirstNumber = 0,
    SecondNumber = 10.25M,
    ThirdNumber = 12.34M,
    FourthNumber = -10
};

Console.WriteLine($"The greatest number is {greatest.GreatestOf4()}");
