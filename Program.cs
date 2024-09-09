Random coin = new Random();
int flip = coin.Next(0,4);
Console.WriteLine((flip == 1) ? "Heads" : "Tails");


string access = "People|manager";
int num = 50;
if (access.Contains("manager"))
{
    if (num > 55)
    {
        Console.WriteLine("Access granted");
    }
    else
    {
        Console.WriteLine("Access denied");
    }
}
else if (access.Contains("People"))
{
    if (num >= 20)
    {
        Console.WriteLine("Access granted");
    }
    else
    {
        Console.WriteLine("Access denied");
    }
}
else
{
    Console.WriteLine("Access denied");
}

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = true;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");

