int a = InputInt("Enter first number: ");
int b = InputInt("Enter second number: ");

int step = 1;



for(int i = 0; i < b; i++)
{
    step *= a;
}
Console.WriteLine(step);


int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}