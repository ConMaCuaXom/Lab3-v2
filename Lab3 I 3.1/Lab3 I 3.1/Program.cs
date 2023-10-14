//Viết chương trình C# thực hiện một số thao tác trên mảng một chiều như sau:
//- Khai báo và khởi tạo 1 mảng số nguyên khoảng 10 phần tử.
//- In ra màn hình các phần tử của mảng.
//- Tìm phần tử nhỏ nhất của mảng
//- Kiểm tra xem mảng có đối xứng không.

int[] a = { 10, 5, 3, 7, 8, 9, 4, 6, 12, 15 };
Console.WriteLine("Cac phan tu cua mang: ");
foreach (int i in a)
{
    Console.Write(i+" ");
}
Console.WriteLine();
Console.WriteLine();
int min = a[0];
foreach (int i in a)
{
    if (i < min)
        min = i;
}
Console.WriteLine("Phan tu nho nhat cua mang la: " + min);
Console.WriteLine();
Console.WriteLine();
bool check = false;
for (int i = 0; i < a.Length/2; i++)
{
    if (a[i] != a[a.Length-i-1])
    {
        check = true;
        //Console.WriteLine("***");
        break;
    }
}
if (check)
    Console.WriteLine("Mang ko doi xung");
else
    Console.WriteLine("Mang co doi xung");



