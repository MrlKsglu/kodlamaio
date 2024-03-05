using kodlamaio.DataAccess.Abstract;
using kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlamaio.DataAccess.Concretes;

public class CourseDal:ICourseDal
{
    List<Course> courses;
    public CourseDal()
    {

        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = ".Net 8 vs..";
        course1.Price = 0;

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "JAVA";
        course2.Description = "Java 17...";
        course2.Price = 0;

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "PYTHON";
        course3.Description = "Python";
        course3.Price = 0;

        courses = new List<Course> { course1, course2, course3 };


    }
    public List<Course> GetAll()
    {
        return courses;

    }

    public void Add(Course course)
    {
        courses.Add(course);
        Console.WriteLine("Eklendi..");
    }

    public void Remove(Course course)
    {
        courses.Remove(course);

        Console.WriteLine("Silindi..");

    }

    public void Update(Course course) 
    {

        Console.WriteLine("Güncellendi");
    
    
    }
}
