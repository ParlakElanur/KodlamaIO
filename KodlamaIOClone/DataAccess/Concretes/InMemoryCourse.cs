using KodlamaIOClone.DataAccess.Abstracts;
using KodlamaIOClone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOClone.DataAccess.Concretes
{
    public class InMemoryCourse : ICourseDal
    {
        List<Course> courses = new List<Course>();

        public InMemoryCourse()
        {
            courses.Add(new Course { Id = 1 , Title = "C#", Description= "Yazılım Geliştirici Yetiştirme Kampı", ImageUrl="C# photo.png", Price=10 });
            courses.Add(new Course { Id = 2, Title = "Java", Description = "Yazılım Geliştirici Yetiştirme Kampı", ImageUrl = "Java photo.jpg ", Price = 20 });
            courses.Add(new Course { Id = 3, Title = "Flutter", Description = "Yazılım Geliştirici Yetiştirme Kampı", ImageUrl = "Flutter Photo ", Price = 30 });
        }
        public Course GetById(int id)
        {
            Course? course = courses.Where(c => c.Id == id).FirstOrDefault();
            return course;
        }
        public void Add(Course course)
        {
           courses.Add(course);
        }
        public void Update(Course course)
        {
            Course courseToUpdate = GetById(course.Id);
            courseToUpdate.Title = course.Title;
            courseToUpdate.Description = course.Description;
            courseToUpdate.ImageUrl = course.ImageUrl;
            courseToUpdate.Price = course.Price;
        }
        public void Delete(Course course)
        {
            courses.Remove(course);
        }
        public List<Course> GetAll()
        {
            return courses;
        }
        
    }
}
