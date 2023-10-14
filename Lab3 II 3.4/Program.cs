//Viết ứng dụng C# thực hiện những công việc sau:
//Tạo lớp Employee (nhân viên) với mô tả:
//-Các thành phần dữ liệu
//o id: Định danh, kiểu int.
//o name: Họ tên nhân viên, kiểu String.
//o yearOfBirth: Năm sinh nhân viên, kiểu int.
//o salaryLevel: Bậc lương, kiểu double.
//o basicSalary: Lương cơ bản kiểu double. (Chú ý lương cơ bản là
//trường được sử dụng chung cho mọi đối tượng của lớp Employee).
//-GetIncome(): trả lại thu nhập của nhân viên. Thu nhập được tính bằng bậc
//lương nhân lương cơ bản (salaryLevel * basicSalary).
//-Display(): hiển thị thông tin về nhân viên. Bao gồm các thông tin: định danh,
//tên, năm sinh, lương cơ bản, thu nhập.
//- Hãy viết chương trình cài đặt lớp Employee và lớp sử dụng Employee.


namespace Lab3_II_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine("Nhap ID nhan vien: ");
            employee.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap ten nhan vien: ");
            employee.name = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh nhan vien: ");
            employee.yearOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap bac luong nhan vien: ");
            employee.salaryLevel = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap luong co ban nhan vien: ");
            employee.basicSalary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            employee.Display();

        }

        public class Employee
        {
            public int id;
            public string name;
            public int yearOfBirth;
            public double salaryLevel;
            public double basicSalary;

            public double GetIncome()
            {
                return basicSalary * salaryLevel;
            }

            public void Display()
            {
                Console.WriteLine("ID nhan vien: " + id);
                Console.WriteLine("Ten nhan vien: " + name);
                Console.WriteLine("Nam sinh: " +  yearOfBirth);
                Console.WriteLine("Luong co ban: " + basicSalary);
                Console.WriteLine("Thu nhap: " + GetIncome());
            }
        }
    }
}