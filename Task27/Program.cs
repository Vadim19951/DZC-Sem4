int[] array = new int[8];

int dis = array.Length;

for(int i = 0; i < array.Length; i++)
{
    array[i]= new Random().Next(1, 10);
    Console.Write(array[i] + ", ");
}
