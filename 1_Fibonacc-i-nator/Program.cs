//Fibonachi sounds like a pasta name, cool
//ulong lets us go higher up
ulong num1 = 1;
ulong num2 = 0;
ulong fibNum;

//We make a list
List<string> fibonacci = new List<string>();
fibonacci.Add("1: " + num1);

//Iterations
uint i = 2;

for(;;)
{
    //Run upto iteration 69 of fibonacci
    if (i < 70)
    {
    fibNum = num1 + num2;
    fibonacci.Add(i + ": " + fibNum);
    num2 = num1;
    num1 = fibNum;
    i++;
    }
    else
        break;
}
Console.WriteLine("The 13th fibonacci degit is:");
Console.WriteLine(fibonacci[12]);
Console.ReadKey();

Console.WriteLine("Fibonacci list from 0 to 69:");
Thread.Sleep(500);
fibonacci.ForEach(i=> Console.Write("{0}\n", i));
Console.ReadKey();