Console.WriteLine("Сколько чисел Вы будете вводить?");
int M = Convert.ToInt32(Console.ReadLine());

int count = 0; //счетчик положительных чисел
for (int times = 0; times < M; times++)
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) count++;
}

Console.Write("Количество положительных чисел: ");
Console.WriteLine(count);