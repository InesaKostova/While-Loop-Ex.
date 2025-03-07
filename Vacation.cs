double needMoney = double.Parse(Console.ReadLine());
double saveMoney = double.Parse(Console.ReadLine());
string action = "";
double currentSum = 0;
int days = 0;

while(true)
{action = Console.ReadLine();
    currentSum = double.Parse(Console.ReadLine());
    days++;
    if(days>=5 && action=="spend")
    {
        Console.WriteLine("You can't save the money.");
        Console.WriteLine($"{days}");
        break;

    }
    else if(action=="save")
    {
        currentSum++;
        days++;
        if(currentSum>=needMoney)
        {
            Console.WriteLine($"You saved the money for {days} days.");
            break;
        }

    }


}
