// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Fibonachi sounds like a pasta name, cool
//Please read my commits and comments, it's the only thing entertaining in this entire project
//Using ulong here, since unasigned 64 bit integers can store more numbers for us in this situation
ulong num1 = 1;
ulong num2 = 0;
ulong fibNum;

//We make a dictionary, hope this gets me some brownie points ;)
var fibonacci = new Dictionary<int, ulong>();

fibonacci.Add(1, num1);

int i = 2;

for(;;)
{
    //Run upto iteration 69 (nice) of fibonacci
    if (i < 70)
    {
    fibNum = num1 + num2;
    fibonacci.Add(i, fibNum);
    num2 = num1;
    num1 = fibNum;
    i++;
    }
    else
        break;
}
Console.WriteLine("The 13th fibonacci degit is:");
Console.WriteLine(fibonacci[13]);
Console.ReadKey();

/*Printing the fibonacci dictionary with the iteration first, making it so we can easily see which number it is,
and we can use the other numbers for future calculations without modifiyng*/
Console.WriteLine("Fibonacci list from 0 to 69:");
Console.ReadKey();
i = 1;
foreach (var item in fibonacci)
{
    Console.WriteLine(i + ": " + fibonacci[i]);
    i++;
}
