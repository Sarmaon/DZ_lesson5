// Задача 36. Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.


        int[] Array = { 4, 8, 5, 4 };
        int result = 0;

        for (int a = 0; a < Array.Length; a++)
        {
            if (Array[a] % 2 == 1)
            {
                result = result + Array[a];
            }
        }
    Console.WriteLine(result);