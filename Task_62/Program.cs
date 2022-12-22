// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Двумерный массив должен быть не меньше 2х2!");
Console.Write("Введите число строк массива: ");
int lenArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int widthArray = Convert.ToInt32(Console.ReadLine());
const int cellWidth = 3;

void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],cellWidth} ");
        }
        Console.WriteLine();
    }
}

int FillArray(int[,] myArray, int count, int startI, int startJ)
{
    for (int j = startJ; j < widthArray; j++)
    {
        if (myArray[startI, j] == 0) myArray[startI, j] = count;
        count++;
    }
    for (int i = startI + 1; i < lenArray; i++)
    {
        if (myArray[i, widthArray - 1] == 0) myArray[i, widthArray - 1] = count;
        count++;
    }
    for (int j = widthArray - 2; j >= startJ; j--)
    {
        if (myArray[lenArray - 1, j] == 0) myArray[lenArray - 1, j] = count;
        count++;
    }
    for (int i = lenArray - 2; i > startI; i--)
    {
        if (myArray[i, startJ] == 0) myArray[i, startJ] = count;
        count++;
    }
    return count;
}

int[,] myArray = new int[lenArray, widthArray];
int count = 1;
int startI = 0;
int startJ = 0;

while (lenArray > 1 & widthArray > 1)
{
    count = FillArray(myArray, count, startI, startJ);
    lenArray--;
    widthArray--;
    startI++;
    startJ++;
}

Console.WriteLine("Спирально заполненный двумерный массив:");
PrintArr(myArray);