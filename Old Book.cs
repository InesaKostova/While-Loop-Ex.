string nameBook = Console.ReadLine();
int countBooks = 0;
string currentBook =Console.ReadLine();

while (nameBook != "No More Books")
{
    if (currentBook == nameBook)
    {
        Console.WriteLine($"You checked {countBooks} books and found it.");
        break;
    }

    countBooks++;
    currentBook = Console.ReadLine();

    if (currentBook == "No More Books")
    {
        Console.WriteLine("The book you search is not here!");
        Console.WriteLine($"You checked {countBooks} books.");
        break;
    }
}