int width = int.Parse(Console.ReadLine());
int lenght = int.Parse(Console.ReadLine());
int size = width * lenght;

string input = Console.ReadLine();
while (input != "STOP")
{
    size -= int.Parse(input);
    if (size <= 0)
    {
        Console.WriteLine($"No more cake left! You need {Math.Abs(size)} pieces more.");
        break;
    }
    input = Console.ReadLine();
}
if (input == "STOP")
{
    Console.WriteLine($"{size} pieces are left.");
}

