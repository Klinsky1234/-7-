
/* Задача 53. Задайте двумерный массив. Напишите программу, которая меняет первую строчку и последнюю.
Например: 
1 4 7 2     8 4 2 4 
5 9 2 3  -> 5 9 2 3
8 4 2 4     1 4 7 2  */

int[,] array = new int[4, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
int x = array.GetLength(0) - 1; // от длины минусуем 1 ,что бы получить индекс (как-то так)

for (int i = 0; i < array.GetLength(1); i++)
{
    (array[0, i], array[x, i]) = (array[x, i], array[0, i]);
}
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

