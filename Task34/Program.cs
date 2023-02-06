// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

ArrayRandomNumbers(numbers);
Console.WriteLine("Полученный массив: ");
//PrintArray(numbers);
int count = 0;

for (int a = 0; a < numbers.Length; a++)
    if (numbers[a] % 2 == 0)
        count++;

Console.WriteLine($"Всего {numbers.Length} чисел, {count} из них четные");

void ArrayRandomNumbers(int[] numbers)
{
    for (int b = 0; b < numbers.Length; b++)
    {
        numbers[b] = new Random().Next(100, 999);
    }
}
{
    Console.Write("[ ");
    for (int b = 0; b < numbers.Length; b++)
    {
        Console.Write(numbers[b] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}