//  TASK 1
Console.WriteLine("\nTask 1 \n");
for (int i = 1; i < 20; i++)
{
    if (i % 2 == 1)
    {
        Console.WriteLine(i);
    }

}

            //  TASK 2

int[] array = {167,42,23,74,45,96,77,18};
Console.WriteLine("\nTask 2, Array: \n");

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}

//  TASK 3

Console.WriteLine();
Console.WriteLine("\nTask 3 \n");

int[,] array2D = { { 1, 2, 3, 4 }, { 14, 15, 16, 17 }, { 4, 5, 6, 7 } };

for (int row = 0; row < 3; row++)
{
    for (int col = 0; col < 4; col++)
    {
        Console.Write($"{array2D[row, col]} ");
    }
}