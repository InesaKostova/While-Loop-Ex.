﻿double returnCoins = double.Parse(Console.ReadLine()) * 100;
int countCoins = 0;

while (returnCoins >= 1)
{
    countCoins++;
    if (returnCoins >= 200)
    {
        returnCoins -= 200;
    }
    else if (returnCoins >= 100)
    {
        returnCoins -= 100;
    }
    else if (returnCoins >= 50)
    {
        returnCoins -= 50;
    }
    else if (returnCoins >= 20)
    {
        returnCoins -= 20;
    }
    else if (returnCoins >= 10)
    {
        returnCoins -= 10;
    }
    else if (returnCoins >= 5)
    {
        returnCoins -= 5;
    }
    else if (returnCoins >= 2)
    {
        returnCoins -= 2;
    }
    else
    {
        returnCoins -= 1;
    }

}

Console.WriteLine(countCoins);
