using KodlamaIOClone.Business.Abstracts;
using KodlamaIOClone.Business.Dtos.Requests;
using KodlamaIOClone.Business.Dtos.Requests.CourseRequest;
using KodlamaIOClone.Business.Dtos.Requests.TutorRequest;
using KodlamaIOClone.Business.Dtos.Response;
using KodlamaIOClone.Business.Dtos.Responses.CourseResponse;
using KodlamaIOClone.Business.Dtos.Responses.TutorResponse;
using KodlamaIOClone.DataAccess.Abstracts;
using KodlamaIOClone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOClone.Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public GetByIdCourseResponse GetById(int id)
        {
            GetByIdCourseResponse getByIdCourseResponse = new GetByIdCourseResponse();

            Course course = _courseDal.GetById(id);
            getByIdCourseResponse.Id = course.Id;
            getByIdCourseResponse.Title = course.Title;
            getByIdCourseResponse.Description = course.Description;
            getByIdCourseResponse.ImageUrl = course.ImageUrl;
            getByIdCourseResponse.Price = course.Price;

            return getByIdCourseResponse;
        }
        public void Add(AddCourseRequest course)
        {
            Random rnd = new Random();

            Course dtoToCourse = new Course();

            dtoToCourse.Id = (int)rnd.NextInt64(0, 100);
            dtoToCourse.Title = course.Title;
            dtoToCourse.Description = course.Description;
            dtoToCourse.ImageUrl = course.ImageUrl;
            dtoToCourse.Price = course.Price;

            _courseDal.Add(dtoToCourse);
        }
        public void Update(UpdateCourseRequest course, int courseID)
        {
            Course courseToUpdate = _courseDal.GetById(courseID);
            courseToUpdate.Id = course.Id;
            courseToUpdate.Title = course.Title;
            courseToUpdate.Description = course.Description;
            courseToUpdate.ImageUrl = course.ImageUrl;

            _courseDal.Update(courseToUpdate, courseID);
        }
        public void Delete(DeleteCourseRequest course)
        {
            Course deleteToCourse = _courseDal.GetById(course.Id);
            _courseDal.Delete(deleteToCourse);
        }
        public List<GetAllCourseResponse> GetAll()
        {
            List<GetAllCourseResponse> courseList = new List<GetAllCourseResponse>();

            foreach (var item in _courseDal.GetAll())
            {
                courseList.Add(new GetAllCourseResponse { Id = item.Id, Title = item.Title, Description = item.Description, ImageUrl = item.ImageUrl, Price = item.Price });
            }
            return courseList;
        }
    }
}
