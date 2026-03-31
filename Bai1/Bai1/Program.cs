int[,] arr1 = new int[3, 3];
Console.Write("\nNhap mang hai chieu ------\n");
for (int i=0; i<3; i++)
{
    for (int j=0; j<3; j++)
    {
        Console.Write("\nNhap phan tu - [{0}, {1}]: ", i, j);
        arr1[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("\nDuyet mang-----------");
for (int i=0; i<3; i++)
{
    Console.Write("\n");
    for (int j=0; j<3; j++)
    {
        Console.Write($"{arr1[i, j]}\t");
    }
}

Console.Write("\n\n");