//Viết chương trình C# thực hiện một số công việc sau:
//- Tạo lớp Car gồm các trường (make, model, color, year) có phạm vi là public
//-Tạo phương thức Start và Stop in ra thông báo về tình trạng của xe.
//- Trong hàm Main khởi tạo đối tượng Car, gán giá trị cho các trường, hiển thị thông
//tin xe, gọi phương thức Start, Stop.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.make = 1995;
            car.model = "VF";
            car.color = "Blue";
            car.year = 2023;

            Console.WriteLine("Thong tin xe");
            Console.WriteLine("Make: " + car.make);
            Console.WriteLine("Model: " + car.model);
            Console.WriteLine("Color: " + car.color);
            Console.WriteLine("Year: " + car.year);

            car.Start();
            car.Stop();
        }

        public class Car
        {
            public int make;
            public string model = "";
            public string color = "";
            public int year;

            public void Start()
            {
                Console.WriteLine("Start!!");
                
            }

            public void Stop() 
            {
                Console.WriteLine("Stop!!");   
            }
        }
           

           
            
          
          
         

    }
}

