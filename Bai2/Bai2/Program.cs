//cong hai ma tran
int[,] arr1 = new int[10, 10];
int[,] arr2 = new int[10, 10];
int[,] matrantong = new int[10, 10];
Console.Write("\nCong hai ma tran---------");
Console.Write("\nNhap kich co cua 2 ma tran: ");
int n = int.Parse(Console.ReadLine());
for (int i=0; i<n; i++)
{
    for (int j=0; j<n; j++)
    {
        Console.Write("\nPhan tu - [{0}, {1}]: ", i, j);
        arr1[i, j] = int.Parse(Console.ReadLine());
    }
}

for (int i=0; i<n; i++)
{
    for (int j=0; j<n; j++)
    {
        Console.Write("\nPhan tu - [{0}, {1}]: ", i, j);
        arr2[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("\nIn ma tran thu nhat----------");
for (int i=0; i<n; i++)
{
    Console.Write("\n");
    for (int j=0; j<n; j++)
    {
        Console.Write($"{arr1[i, j]}\t");
    }
}

Console.Write("\n\n");

Console.WriteLine("\nIn ma tran thu hai--------");
for (int i=0; i<n; i++)
{
    Console.Write("\n");
    for (int j=0; j<n; j++)
    {
        Console.Write($"{arr2[i, j]}\t");
    }
}

Console.Write("\n\n");

Console.WriteLine("\nCong hai ma tran");
for (int i=0; i<n; i++)
{
    for (int j=0; j<n; j++)
    {
        matrantong[i,j] = arr1[i,j] + arr2[i,j];
    }
}

Console.WriteLine("Ma tran tong cua hai ma tran tren-------");
for (int i=0; i<n; i++)
{
    Console.Write("\n");
    for (int j=0; j<n; j++)
    {
        Console.Write($"{matrantong[i, j]}\t");
    }
}
Console.Write("\n\n");

//tru hai ma tran
int[,] arr3 = new int[10, 10];
int[,] arr4 = new int[10, 10];
int[,] hieumatran = new int[10, 10];
Console.Write("\nHieu hai ma tran---------");
Console.Write("\nNhap kich co cua 2 ma tran: ");
int m = int.Parse(Console.ReadLine());
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write("\nPhan tu - [{0}, {1}]: ", i, j);
        arr3[i, j] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write("\nPhan tu - [{0}, {1}]: ", i, j);
        arr4[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("\nIn ma tran thu nhat----------");
for (int i = 0; i < m; i++)
{
    Console.Write("\n");
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{arr3[i, j]}\t");
    }
}

Console.Write("\n\n");

Console.WriteLine("\nIn ma tran thu hai--------");
for (int i = 0; i < m; i++)
{
    Console.Write("\n");
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{arr4[i, j]}\t");
    }
}

Console.Write("\n\n");

Console.WriteLine("\nTru hai ma tran");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        hieumatran[i, j] = arr3[i, j] - arr4[i, j];
    }
}

Console.WriteLine("Hieu cua hai ma tran tren-------");
for (int i = 0; i < m; i++)
{
    Console.Write("\n");
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{hieumatran[i, j]}\t");
    }
}
Console.Write("\n\n");