// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// 1. Задать массив рандомно
// 2. Вычисление среднего арифметического столбцов
// 3. вывод массива и среднего арифметического


// 1. Задать массив рандомно
Random random = new Random();

int [,] array = new int[random.Next(1, 10), random.Next(1, 10)];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

// 2. Вычисление среднего арифметического столбцов
// 3. вывод массива и среднего арифметического
for (int j = 0; j < array.GetLength(1); j++)
{
     double Sum = 0;
     for (int i = 0; i < array.GetLength(0); i++)
     {
     Sum += array[i, j];
     } 
     double Sr = Sum / array.GetLength(0);
     Sr = Math.Round(Sr, 1);
     Console.Write("Среднее арифметичекое столбца:" + (j+1) ); 
     Console.WriteLine($" { Sr } ");
}







