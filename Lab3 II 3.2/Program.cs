//Tạo ứng dụng C# và thực hiện những công việc sau.
//- Khai báo và khởi tạo một mảng 2 chiều với 4 dòng và 4 cột.
//- In mảng theo hàng cột.
//- Tính tổng các phần tử mà có chỉ số hàng=chỉ số cột.
//- In ra các phần tử nhỏ nhất trên cột.
//- Liệt kê các phần tử chia hết cho 7.
//- Tìm tổng các phần tử nằm trên đường viền của mảng.
//- Chuyển thành mảng 1 chiều rồi sắp xếp tăng dần.



//- Khai báo và khởi tạo một mảng 2 chiều với 4 dòng và 4 cột.
int[,] a = { { 1, 3, 4, 9 }, { 5, 7, 8, 6 }, { 9, 10, 11, 21 }, { 12, 14, 20, 25 } };

//- In mảng theo hàng cột.
Console.WriteLine("Mang 2 chieu da tao gom: ");
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}

//- Tính tổng các phần tử mà có chỉ số hàng=chỉ số cột.
Console.WriteLine();
int sum = 0;
Console.Write("Tong cac phan tu co chi so hang = so cot: ");
for (int k = 0; k<4 ; k++)
{
    sum = sum + a[k,k];
}
Console.WriteLine(sum);

//- In ra các phần tử nhỏ nhất trên cột.
Console.WriteLine();
Console.WriteLine("Cac phan tu nho nhat tren cot la: ");
for (int i = 0; i < a.GetLength(1);i++)
{
    int min = a[0,i];
    for (int j = 0;j < a.GetLength(0);j++)
    {
        if (a[j,i] < min)
            min = a[j,i];
    }
    Console.WriteLine("Cot {0}: {1}",i + 1,min);
}

//- Liệt kê các phần tử chia hết cho 7
Console.WriteLine();
Console.Write("Cac phan tu chia het cho 7: ");
for (int i = 0;i < a.GetLength(0);i++)
{
    for (int j = 0;j < a.GetLength(1);j++)
    {
        if (a[i, j] % 7 == 0)
            Console.Write(a[i, j] + " ");
    }
}

//- Tìm tổng các phần tử nằm trên đường viền của mảng.
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Tong cac phan tu nam tren duong vien cua mang: ");
int summ = 0;
for (int i = 0; i < a.GetLength(0); i++)
{
    summ = summ + a[0, i] + a[(a.GetLength(0) -1),i];
}
for (int i = 0; i < a.GetLength(1); i++)
{
    summ = summ + a[i,0] + a[i,(a.GetLength(0) - 1)];
}
summ = summ - a[0, 0] - a[0, a.GetLength(0) - 1] - a[a.GetLength(0) - 1, 0] - a[a.GetLength(0) - 1, a.GetLength(1) - 1];
Console.WriteLine(summ);

//- Chuyển thành mảng 1 chiều rồi sắp xếp tăng dần.
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Sap xep mang 2 chieu thanh 1 chieu: ");
int[] b = new int[16];
int c = 0;
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        b[c] = a[i, j];
        c++;
    }
}
foreach (int i in b)
{
    Console.Write(i + " ");
}