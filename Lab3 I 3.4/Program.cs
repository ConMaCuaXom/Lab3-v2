//Viết chương trình C# thực hiện một số công việc sau:
//- Tạo lớp Contact với các trường (id, firstname, lastname, address, phone, email), các
//trường khai báo với phạm vi private.
//-Tạo các thuộc tính cho các trường.
//- Viết phương thức hiển thị thông tin contact.
//- Tạo 2 đối tượng và gọi phương thức để test.


namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact c1 = new Contact();
            c1.Id = "akshdwi";
            c1.FirstName = "Hoo";
            c1.LastName = "Haa";
            c1.Address = "HaNoi";
            c1.Phone = 084515156;
            c1.Email = "sadguyd@gmail.com";

            Contact c2 = new Contact();
            c2.Id = "wydguewd";
            c2.FirstName = "Hee";
            c2.LastName = "Hii";
            c2.Address = "HCM City";
            c2.Phone = 080451586;
            c2.Email = "ahdwdwd@gmail.com";

            c1.Display();
            Console.WriteLine();
            Console.WriteLine();
            c2.Display();
        }    
    }

    public class Contact
    {
        private string id = "";
        private string firstName = "";
        private string lastName = "";
        private string address = "";
        private float phone;
        private string email = "";

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public float Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public void Display()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("First name: " + FirstName);
            Console.WriteLine("Last name: " +  LastName);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Phone: " + Phone);
            Console.WriteLine("Email: " +  Email);
        }
    }

}