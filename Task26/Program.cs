int a = InputInt("Введите число: ");

int b = 0;
int sum = 0;

int count = 0;

while(a > 0)
{
    b = a % 10;
    sum = sum + b;
    a = a / 10;
    count++;
}

 Console.WriteLine(sum);


int InputInt(string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}
