using KodlamaIOClone.Business.Dtos.Requests;
using KodlamaIOClone.Business.Dtos.Requests.CourseRequest;
using KodlamaIOClone.Business.Dtos.Response;
using KodlamaIOClone.Business.Dtos.Responses.CourseResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOClone.Business.Abstracts
{
    public interface ICourseService
    {
        void Add(AddCourseRequest category);
        GetByIdCourseResponse GetById(int id);      
        void Update(UpdateCourseRequest category);
        void Delete(DeleteCourseRequest category);
        List<GetAllCourseResponse> GetAll();
    }
}
