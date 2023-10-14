//Tạo lớp Book để biểu diễn quyển sách
//✔ Các trường.
//- string author ( tác giả).
//- int pages(số trang).
//- string isbn(mã số tiêu chuẩn quốc tế).
//- string title(tiêu đề).
//- int current page(trang hiện tại)
//  Tạo constructor mặc định và thiết lập currentpage cho 1.
//✔ Tạo constructor với tất cả các tham số để khởi tạo các trường tương ứng.
//✔ Tạo phương thức flipPageForward (lật sang trang trước).
//✔ Tạo phương thức flipPageBackward (lật sang trang sau).
//✔ Viết chương trình để kiểm thử tất các tính năng của Book.

namespace Lab3_II_3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Book book1 = new Book("Tac cmn gia", 100, "MaSoQuocTe","Tieu cmn de",50);

            book.FlipPageBackward();
            book.FlipPageForward();
            book1.FlipPageBackward();
            book1.FlipPageForward();
        }


        public class Book
        {
            public string author;
            public int pages;
            public string isbn;
            public string title;
            public int currentPage;


            public Book()
            {
                currentPage = 1;
            }

            public Book(string author, int pages, string isbn, string title, int currentPage)
            {
                this.author = author;
                this.pages = pages;
                this.isbn = isbn;
                this.title = title;
                this.currentPage = currentPage;
            }

            public void FlipPageForward()
            {
                currentPage--;
                Console.WriteLine("So trang hien tai: " +  currentPage);
            }

            public void FlipPageBackward()
            {
                currentPage++;
                Console.WriteLine("So trang hien tai: " +  currentPage);
            }
        }
    }
}
