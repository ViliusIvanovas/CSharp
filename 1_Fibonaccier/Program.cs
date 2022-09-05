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