//Tạo ứng dụng C# và thực hiện những công việc sau.
//- Khởi tạo một mảng 1 chiều số nguyên gồm 10 phần tử.
//- Tìm phần tử nhỏ nhất của mảng.
//- Đảo ngược mảng.
//- Sắp xếp mảng tăng hoặc giảm.
//- Tìm phần tử là số nguyên tố.
//- In ra số lượng các số dương liên tiếp nhiều nhất.
//- Tính trung bình cộng các phần tử dương.
//- Kiểm tra xem mảng có phải chứa các phần tử âm dương, đan xen nhau không?.



//- Khởi tạo một mảng 1 chiều số nguyên gồm 10 phần tử.
int[] a = new int[10];
Console.WriteLine("Nhap vao cac phan tu cua mang:");
for (int i = 0; i < a.Length; i++)
{
    Console.Write("Phan tu thu {0}: ", i+1);
    a[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("Mang thao tac co 10 phan tu gom: ");
foreach (int i in a)
{
    Console.Write(i + " ");
}
Console.WriteLine();
Console.WriteLine();

//- In ra số lượng các số dương liên tiếp nhiều nhất.
Console.Write("So luong cac so duong lien tiep nhieu nhat: ");
int[] b = new int[a.Length];
int maxD = 0;
for (int i = 0; i < a.Length; i++)
{
    if (a[i] >= 0)
    {
        maxD++;
        b[i] = maxD;       
    }
    if (a[i] < 0)
    {
        maxD = 0;
        b[i] = 0;        
    }
}
Console.WriteLine(b.Max());


//- Tìm phần tử nhỏ nhất của mảng.
Console.Write("Phan tu nho nhat cua mang la: ");
int min = a[0];
foreach (int i in a)
{
    if (i < min) 
        min = i;
}
Console.Write(min);
Console.WriteLine();

//- Kiểm tra xem mảng có phải chứa các phần tử âm dương, đan xen nhau không?.
bool checkk = true;
for (int x = 0; x < a.Length - 1; x++)
{
    if (a[x]>=0 && a[x+1] >=0 || a[x] <= 0 && a[x+1] <= 0)
    {
        checkk = false;
        Console.WriteLine("Mang ko co cac phan tu am duong dan xen!!");
        break;
    }
}
if (checkk)
    Console.WriteLine("Mang co cac phan tu am duong dan xen!!");



//- Đảo ngược mảng.
Console.WriteLine("Mang dao nguoc la: ");
for (int i = 9;i >=0;i--)
{
    Console.Write(a[i] + " ");
}
Console.WriteLine();

//- Sắp xếp mảng tăng hoặc giảm.
Console.WriteLine("Mang sap xep theo thu tu tang dan: ");
Array.Sort(a);
foreach (int i in a)
{
    Console.Write(i + " ");
}
Console.WriteLine();

//- Tìm phần tử là số nguyên tố.
Console.WriteLine("So nguyen to trong mang gom: ");
foreach (int i in a)
{
    bool check = true;
    for (int j = 2;j<i;j++)
    {
        if (i % j == 0)
            check = false;
    }
    if (check)
        Console.Write(i + " ");
}
Console.WriteLine();

//- Tính trung bình cộng các phần tử dương.
Console.Write("Trung binh cong cac phan tu duong la: ");
int tbc = 0;
int tbc2 = 0;
foreach (int i in a)
{
    if (i >= 0)
    {
        tbc = tbc + i;
        tbc2++;
    }       
}
double tbc3 = (tbc / tbc2) * 1.0;
Console.WriteLine(tbc3);
Console.WriteLine();





