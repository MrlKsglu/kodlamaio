// See https://aka.ms/new-console-template for more information
using kodlamaio.Business;
using kodlamaio.DataAccess.Concretes;
using kodlamaio.Entities;



CourseManager courseManager = new CourseManager(new CourseDal());
List<Course> courses = courseManager.GetAll();

for (int i = 0; i < courses.Count; i++)
{
    
    Console.WriteLine(courses[i].Name );
}

InstructorManager ınstructorManager = new InstructorManager(new InstructorDal());
List<Instructor> ınstructors = ınstructorManager.GetAll();
for (int i = 0; i < ınstructors.Count; i++)
{
    
    Console.WriteLine(ınstructors[i].Name);
}
