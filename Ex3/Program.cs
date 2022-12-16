int [] CreateRandomArray(int length)
{
    int [] array = new int [length];
    Random N = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = N.Next(1, 20);
        Console.WriteLine(array[i]);
    }
    return array;
}

Console.WriteLine("Введите длину массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int [] arr1 = CreateRandomArray(len);

int sum = 0;
int composition = 0;
int l = len;
for (int i = 0; i < len / 2; i++)
{
    composition = arr1[i] * arr1[l-1];
    sum = sum + composition;
    l = l - 1;
}
Console.Write("Cумма произведений пар чисел: ");
Console.WriteLine(sum);