int badGrade = int.Parse(Console.ReadLine());
double gradeSum = 0;
int gradeCount = 0;
int badGradeCount = 0;
string lastName = "";

while (true)
{
    string name=Console.ReadLine();
    if(name =="Enough")
    {
        Console.WriteLine($"Average score: {gradeSum / gradeCount:F2}");
        Console.WriteLine($"Number of problems: {gradeCount}");
        Console.WriteLine($"Last problem: {lastName}");
        break;
    }
    int currentGrade = int.Parse(Console.ReadLine());
    if(currentGrade<=4)
    {
        badGradeCount++;
        if(badGradeCount==badGrade)
        {
            Console.WriteLine($"You need a break, {badGrade} poor grades.");
            break;
        }

    }
    gradeCount++;
    gradeSum+= currentGrade;
    lastName = name;
}