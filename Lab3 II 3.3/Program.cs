//Tạo ứng dụng C# và thực hiện công việc theo mô tả sau:
//Cho 2 mảng như sau.
//Mảng CAN 10 phần tử
//Giáp Ất Bính Đinh Mậu Kỷ Canh Tân Nhâm Quý
//Mảng CHI 12 phần tử
//Tí Sửu Dần Mão Thìn Tỵ Ngọ Mùi Thân Dậu Tuất Hợi
//- Theo lịch âm thì mỗi năm sẽ ứng với CAN+CHI.
//- Giả sử năm 2010 là năm CANH DẦN.
//- Hãy nhập vào 1 năm bất kỳ và in ra năm âm tương ứng, bạn có thể đổi lại vị trí bắt
//đầu của CAN CHI cho phù hợp


Console.WriteLine("Nhap vao so nam: ");
int a = Convert.ToInt32(Console.ReadLine());
string[] can = new string[] { "Canh","Tan","Nham","Quy","Giap","At","Binh","Dinh","Mau","Ky"};
string[] chi = new string[] { "Than", "Dau", "Tuat", "Hoi", "Tý", "Suu", "Dan", "Mao", "Thin", "Ty", "Ngo","Mui" };
Console.WriteLine("Nam ay la: " + can[a % 10] + " " + chi[a % 12]);