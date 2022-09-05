//Fibonachi sounds like a pasta name, cool
uint num1 = 1;
uint num2 = 0;
uint fibNum;

List<string> fibonachi = new List<string>();
fibonachi.Add("0: " + num1);

uint sequence = 1;

for(;;)
{
    if (sequence < 100000)
    {
    fibNum = num1 + num2;
    fibonachi.Add(sequence + ": " + fibNum);
    num2 = num1;
    num1 = fibNum;
    sequence++;
    }
    else
        break;
}
Console.WriteLine("The 13th fibonacci degit is:");
Console.WriteLine(fibonachi[13]);
Console.ReadKey();

Console.WriteLine("Fibonacci list from 0 to 100 thousand");
fibonachi.ForEach(i=> Console.Write("{0}\n", i));
Console.ReadKey();

Console.Title = "Chapter 0: Introductions";
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Green;

#region intro

Console.WriteLine("This is a story, where you are in control.");
Console.ReadKey();
Console.WriteLine("Not much unlike a choose your own adventure.");
Console.ReadKey();
Console.WriteLine("The way you will be making decisions, is by choosing one of the words, from the paranthesis.");
Console.ReadKey();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("But enough of that, your adventure begins now!");
Thread.Sleep(500);
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Do you wish to continue?");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("(Yes/No)");
Console.ForegroundColor = ConsoleColor.Yellow;
string trait = "?";

#endregion

#region choice

string input = Console.ReadLine();
switch (input)
{
    case "Yes":
        Console.WriteLine("You're very determined, this merits a reward:");
        trait = "Determined participant";
        break;
    case "No":
        Console.WriteLine("Unwilling, though I think you'll over come it:");
        trait = "Unwilling participant";
        Console.WriteLine("You unlock the trait \"Unwilling participant\"");
        break;
    default:
        Console.WriteLine("You're forcefully dragged into it anyway:");
        trait = "Forced participant";
        break;
}

#endregion

//Player stats
int maxHP = 100;
int currentHP = 80;
int ATK = 10;
int stamina = 70;
string specialSkill = "?";
List<string> party = new List<string>();

#region chapter 0

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("You wake up in a place you've never been before.");
Console.ReadKey();
Console.WriteLine("You are in something that might look like a medieval bedroom.");

Console.ForegroundColor = ConsoleColor.Blue;
Console.ReadKey();
//omg skyrim reference googogod+fod
Console.WriteLine("You're finally awake!");
Console.ReadKey();
Console.WriteLine("We're going to be adventures now");
Console.ReadKey();
Console.WriteLine("Could you start by introducing yourself?");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Input your name:");
Console.ForegroundColor = ConsoleColor.Yellow;
string playerName = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Blue;
//Add player to the party list
party.Add(playerName);
Console.WriteLine(playerName + ",");
Console.WriteLine(" What a wonderfull name!");
Console.ReadKey();
Console.WriteLine("Shoot I totally forgot to tell you my name.");
Thread.Sleep(100);
Console.WriteLine("Ashi.");
party.Add("Ashi");
Thread.Sleep(100);
Console.WriteLine("That's my name, so feel free to call me that.");
Console.ReadKey();
Console.WriteLine("Well uhm, now that that is settled.");
Console.ReadKey();
Console.WriteLine("Why don't we try to get going, after all this is only a loan room.");
Console.ReadKey();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("You head out of the in, heading for the nearby village.");

#endregion

Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("END OF CHAPTER 0: Introductions");
Console.ReadKey();
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("CURRENT STATS:");
Console.ReadKey();
Console.WriteLine("Max HP: " + maxHP);
Console.WriteLine("Current HP: " + currentHP);
Console.WriteLine("ATK: " + ATK);
Console.WriteLine("Stamina: " + stamina);
Console.WriteLine("Special skill: " + specialSkill);
Console.WriteLine("Trait: " + trait);
Console.ReadKey();
Console.WriteLine("Your party members are:");
party.ForEach(i=> Console.Write("{0}\n", i));
Console.ReadKey();
Console.ForegroundColor = ConsoleColor.Green;
Console.Title = "Chapter 1: Billsburg";
Console.WriteLine("STARING CHAPTER 1: Billsburg");

#region food cool

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Placeholder text");
Console.ReadKey();
Console.WriteLine("We should get something to eat");
Console.ReadKey();
Console.WriteLine("Here I found the menu, which would you prefer");

string food;
bool valid = false;
do
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Resturant Vilius' menu");

    string[] menu = { "Pretzel", "Salmon", "Crayfish", "Lasagna" };
    Array.Sort(menu);
    foreach (string i in menu)
    {
        Console.WriteLine(i);
    }

    food = Console.ReadLine();

    string lFood = food.ToLower();

    switch (lFood)
    {
        case "pretzel":
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("A pretzel it is.");
            food = "Pretzel";
            valid = true;
            break;
        case "salmon":
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Some salmon it is.");
            food = "Salmon";
            valid = true;
            break;
        case "crayfish":
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Some crayfish it is.");
            food = "Crayfish";
            valid = true;
            break;
        case "lasagna":
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Looks like we're getting lasagna");
            food = "Lasagna";
            valid = true;
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Maybe we should take a look at the menu again.");
            valid = false;
            break;
    }
} while (valid == false);

//ran out of fucks to give, story mostly ends here, its just mostly placeholders and cool code forward, good luck
Console.WriteLine("Placeholder text eating eating");
Thread.Sleep(100);
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Hey uhm, do you have room for another traveler on your team?");
Thread.Sleep(100);
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("A tall woamn approached your table.");
Console.ReadKey();
Console.WriteLine("From the looks of it she would weild a big sword");
Console.ReadKey();
Console.WriteLine("She might be a worthy addition to the party");
Console.ReadKey();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("ashi simping over big strong woman blah blah placeholder text");
Console.ReadKey();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("I would love to join your party blah blah blah");
party.Add("Dehya");
//what an amazing reveal, best story telling of this year
Console.WriteLine("I'm Dehya btw.");

#endregion

Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("END OF CHAPTER 1: Billsburg");
Console.ReadKey();
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("You've gained another Party member");
Console.ReadKey();
Console.WriteLine("You're up to " + party.Count + " Party members now.");
Console.ReadKey();
Console.WriteLine("Your party members are:");
party.ForEach(i=> Console.Write("{0}\n", i));
Console.ReadKey();
Console.ForegroundColor = ConsoleColor.Green;
Console.Title = "Chapter 2: Billsburging continues";
Console.WriteLine("STARING CHAPTER 2: Billsburging continues");

//jeg mangler desperat søvn