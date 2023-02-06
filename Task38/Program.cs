// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];

FillArrayRandomNumbers(numbers);
Console.WriteLine("Полученный массив: ");

PrintArray(numbers);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int a = 0; a < numbers.Length; a++)
{
    if (numbers[a] > max)
    {
        max = numbers[a];
    }
    if (numbers[a] < min)
    {
        min = numbers[a];
    }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for (int b = 0; b < numbers.Length; b++)
    {
        numbers[b] = Convert.ToDouble(new Random().Next(100, 999)) / 100;
    }
}
void PrintArray(double[ ] numbers)
{
    Console.Write("[ ");
    for (int b = 0; b < numbers.Length; b++)
    {
        Console.Write(numbers[b] + "; ");
    }
    Console.Write("]");
    Console.WriteLine();
}