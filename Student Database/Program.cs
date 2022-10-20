
Console.WriteLine("Welcome to the GC Student Database!");
bool runAgain = true;

while (runAgain)
{
    string[] studentNames = { "Alexis Greene", "Hayden Evans", "Kelsey Wright", "Nicole Brennan", "Tegan Underwood", "Connor Wood", "Joseph Price", "Robert Munn", "Troy Dalton", "Zac Smith" };

    string[] studentHometown = { "Ann Arbor", "Grand Rapids", "Homosassa", "Wilmington", "Grand Rapids", "Detroit", "Austin", "Lansing", "Kalamazoo", "Detroit" };

    string[] studentFavoriteFood = { "Quesadilla", "Pepperoni Pizza", "Grilled Cheese", "Spaghetti", "Chicken Wings", "Cheeseburger", "Chicken Shawarma", "Cheese Pizza", "Steak", "Tacos" };

    Console.WriteLine("Would you like to see a list of all the students in this database? Enter a 'y' or a 'n'");

    while (true)
    {
        string userAnswer = Console.ReadLine().ToLower();
        if (userAnswer == "y")
        {
            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine($"The students in the database are: {studentNames[i]}");
            }
            break;
        }
        else if (userAnswer == "n")
        {
            break;
        }
        else
        {
            Console.WriteLine("This is not a valid response. Please enter 'y' or 'n'.");  
        }
    }
    
    Console.WriteLine("To learn about a specific student, please enter a number between 1 and 10.");
    
    int studentNumber;
    while (true)
    {
        studentNumber = Convert.ToInt32(Console.ReadLine());
        if (studentNumber <= 0 || studentNumber > studentNames.Length)
        {
            Console.WriteLine("I'm sorry. That number is out of range. Please enter a number 1-10.");
        }
        else
        {
            break;
        }

    }

    int studentIndex = studentNumber - 1;
    Console.WriteLine($"Student {studentNumber} is {studentNames[studentIndex]}. What would you like to know about {studentNames[studentIndex]}? Enter 'hometown' or 'favorite food'.");

    while (true)
    {
        string studentInfo = Console.ReadLine().ToLower();
        if (studentInfo == "hometown")
        {
            Console.WriteLine($"{studentNames[studentIndex]} is from {studentHometown[studentIndex]}.");
            break;
        }
        else if (studentInfo == "favorite food")
        {
            Console.WriteLine($"{studentNames[studentIndex]} likes to eat {studentFavoriteFood[studentIndex]}.");
            break;
        }
        else
        {
            Console.WriteLine("Sorry, that information is not available. Please try again. Enter 'hometown' or 'favorte food'.");
        }
    }

    while(true)
    {
        Console.WriteLine("Would you like to learn about another student? Enter a 'y' or a 'n'.");
        string userInput = Console.ReadLine().ToLower();
        if (userInput == "y")
        {
            break;
        }
        else if(userInput == "n")
        {
            runAgain = false;
            break;
        }
        else
        {
            Console.WriteLine("That is not a valid response. Please try again.");
        }
    }
}

