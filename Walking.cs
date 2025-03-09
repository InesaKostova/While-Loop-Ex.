int goal = 10000;
int totalSteps = 0;
while (totalSteps < goal)
        {
            string input = Console.ReadLine();

            if (input == "Going home")
            {
                int stepsHome = int.Parse(Console.ReadLine());
                totalSteps += stepsHome;
                break;
            }
            else
            {
                int steps = int.Parse(input);
                totalSteps += steps;
            }
        }
        if (totalSteps >= goal)
        {
            Console.WriteLine("Goal reached! Good job!");
            if (totalSteps > goal)
            {
                Console.WriteLine($"{totalSteps - goal} steps over the goal!");
            }
        }
        else
        {
            Console.WriteLine($"{goal - totalSteps} more steps to reach goal.");
        }
    

