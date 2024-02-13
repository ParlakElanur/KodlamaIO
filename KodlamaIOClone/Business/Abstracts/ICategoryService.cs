using KodlamaIOClone.Business.Dtos.Requests;
using KodlamaIOClone.Business.Dtos.Response;
using KodlamaIOClone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOClone.Business.Abstracts
{
    public interface ICategoryService
    {
        void Add(AddCategoryRequest category);
        GetByIdCategoryResponse GetById(int id);
        List<GetAllCategoryResponse> GetAll();
        void Update(UpdateCategoryRequest category,int id);
        void Delete(DeleteCategoryRequest category);
    }
}
