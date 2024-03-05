using kodlamaio.DataAccess.Abstract;
using kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlamaio.DataAccess.Concretes;

public class InstructorDal:IInstructorDal
{
    List<Instructor> instructors;

    public InstructorDal()
    {
        Instructor instructor1 = new Instructor();
        instructor1.Id = 1;
        instructor1.Name = "Engin Demiroğ";


        Instructor instructor2 = new Instructor();
        instructor2.Id = 2;
        instructor2.Name = "Meral Köseoğlu";

        instructors = new List<Instructor>() { instructor1, instructor2 };


    }

    public List<Instructor> GetAll()
    {
        
        return instructors;

    }

    public void Add(Instructor instructor)
    {
        instructors.Add(instructor);
        Console.WriteLine("Eklendi..");
    }

    public void Remove(Instructor instructor)
    {
        instructors.Remove(instructor);

        Console.WriteLine("Silindi..");

    }

    public void Update(Instructor instructor)
    {

        Console.WriteLine("Güncellendi");


    }
}
