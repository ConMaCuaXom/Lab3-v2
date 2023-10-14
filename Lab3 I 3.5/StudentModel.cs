using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab3_I_3._5
{
    public class StudentModel
    {
        List<Student> listStudent;
        

    public StudentModel()
    {
        this.listStudent = new List<Student>()
        {
            new Student(){Id=1,Name="Ha",Age=18},
            new Student(){Id=2,Name="He",Age=19},
            new Student(){Id=3,Name="Hi",Age=20},
            new Student(){Id=4,Name="Hu",Age=21},
            new Student(){Id=5,Name="Hy",Age=22},
        };
        
    }

    public List<Student> GetStudent()
    {
        return listStudent;
    }

    public Student GetStudent(int id)
    {
            Student student = null;
            foreach (var item in listStudent)
            {
                if (item.Id == id)
                {
                    student = item;
                }
            }
            return student;
    }
    
    public List<Student> GetStudents(int x, int y)
        {
            List<Student> students = new List<Student>();
            foreach (var item in listStudent)
            {
                if (item.Age>= x && item.Age<= y)
                {
                    students.Add(item);
                }
            }
            return students;
        }


    }

    
}
