// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Введите количество чисел для проверки: ");
int M = int.Parse(Console.ReadLine()!);
int[] arr = ArraySize(M);
Console.WriteLine($"Из чисел: {String.Join(", ", arr)}, положительных будет {PositivNumb(arr)}");

int[] ArraySize(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(-100, 100);
    }
    return res;
}
int PositivNumb(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) res++;
    }
    return res;
}