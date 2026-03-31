//tính tổng các phần tử trên đường chéo chính của ma trận
int[,] arr1 = new int[50, 50];
int sum = 0;
Console.Write("\ntong cac phan tu tren duong cheo chinh cua ma tran");
Console.Write("\nNhap kich thuoc cua ma tran: ");
int n = int.Parse(Console.ReadLine());
for (int i=0; i<n; i++)
{
    for (int j=0; j<n; j++)
    {
        Console.Write("\nPhan tu - [{0}, {1}]: ", i, j);
        arr1[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("\nIn ma tran------");
for (int i=0; i<n; i++)
{
    Console.Write("\n");
    for (int j=0; j<n; j++)
    {
        Console.Write($"{arr1[i, j]}\t");
        if (i==j)
        {
            sum = sum + arr1[i, j];
        }
    }
}
Console.Write($"\nTong cac phan tu tren duong cheo chinh la: {sum}");