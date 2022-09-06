//Fibonachi sounds like a pasta name, cool
uint num1 = 1;
uint num2 = 0;
uint fibNum;

List<string> fibonacci = new List<string>();
fibonacci.Add("1: " + num1);

uint sequence = 2;

for(;;)
{
    if (sequence < 100)
    {
    fibNum = num1 + num2;
    fibonacci.Add(sequence + ": " + fibNum);
    num2 = num1;
    num1 = fibNum;
    sequence++;
    }
    else
        break;
}
Console.WriteLine("The 13th fibonacci degit is:");
Console.WriteLine(fibonacci[12]);
Console.ReadKey();

Console.WriteLine("Fibonacci list from 0 to 100:");
Thread.Sleep(500);
fibonacci.ForEach(i=> Console.Write("{0}\n", i));
Console.ReadKey();