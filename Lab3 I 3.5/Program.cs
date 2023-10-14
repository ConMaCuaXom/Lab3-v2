//Viết chương trình C# thực hiện một số công việc sau:
//- Tạo lớp Student với các thuộc tính khai báo tự động (Id, Name, Age).
//- Tạo phương thức Display để hiển thị thông tin sinh viên.
//- Tạo lớp StudentModel.cs
//- Khởi tạo một danh sách gồm 5 sinh viên trong StudentModel.
//- Tạo các phương thức overloading “GetStudent” trong lớp StudentModel để:
//o Trả về toàn bộ danh sách sinh viên
//o Trả về sinh viên theo Id.
//o Trả về sinh viên có tuổi từ x->y.
//- Khởi tạo StudentModel và test trong Main.




namespace Lab3_I_3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentModel studentModel = new StudentModel();
            List<Student> students = new List<Student>();
            List<Student> students2 = new List<Student>();
            students = studentModel.GetStudent();
            Console.WriteLine("List danh sach 5 sv gom: ");
            foreach (var item in students)
            {
                item.Display();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("SV co ma ID = 2 la: ");
            Student stID = new Student();
            stID =  studentModel.GetStudent(2);
            stID.Display();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("SV co do tuoi tu 19 den 22 la: ");
            students2 = studentModel.GetStudents(19, 22);
            foreach (var item in students2)
            {
                item.Display();
            }
        }
    }
}