//Viết chương trình C# thực hiện một số thao tác trên mảng hai chiều như sau:
//- Khai báo vào khởi tạo mảng 2 chiều 4x3
//- Duyệt mảng và in theo ma trận hàng cột
//- In ra các phần tử có chỉ số hàng bằng chỉ số cột
//- In ra các phần tử lớn nhất trên hàng

using System.ComponentModel.DataAnnotations;

int[,] a = { { 4, 5, 3 }, { 9, 7, 8 }, { 10, 12, 13 }, { 22, 25, 27 } };
Console.WriteLine("Noi dung mang 2 chieu: ");
for (int i = 0; i <= a.GetUpperBound(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j <= a.GetUpperBound(1); j++)
    {
        Console.Write(" {0} ", a[i,j]);
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Phan tu co chi so hang bang chi so cot la: ");
for (int i = 0;i <= a.GetUpperBound(0); i++)
{
    for (int j = 0;j <= a.GetUpperBound(1); j++)
    {
        if (i== j)
            Console.Write(" "+ a[i,j]);
    }
}
Console.WriteLine();

Console.WriteLine("Cac phan tu lon nhat tren hang: ");
for(int x = 0;x <= a.GetUpperBound(0); x++)
{
    int max = a[x, 0];
    for (int y = 0;y <= a.GetUpperBound(1); y++)
    {
        if ( max < a[x,y])
        {
            max = a[x,y];           
        }       
    }
    Console.WriteLine("Hang {0}: {1} ", x + 1, max);
}