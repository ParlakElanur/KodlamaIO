using KodlamaIOClone.Business.Abstracts;
using KodlamaIOClone.Business.Dtos.Requests;
using KodlamaIOClone.Business.Dtos.Response;
using KodlamaIOClone.DataAccess.Abstracts;
using KodlamaIOClone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOClone.Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public GetByIdCategoryResponse GetById(int id)
        {
            GetByIdCategoryResponse getByIdCategoryResponse = new GetByIdCategoryResponse();
            Category category = _categoryDal.GetById(id);
            getByIdCategoryResponse.Id = category.Id;
            getByIdCategoryResponse.Name = category.Name;

            return getByIdCategoryResponse;
        }
        public void Add(AddCategoryRequest category)
        {
            Category dtoToCategory = new Category();
            dtoToCategory.Id = category.Id;
            dtoToCategory.Name = category.Name;
           
            _categoryDal.Add(dtoToCategory);
        }
        public void Update(UpdateCategoryRequest category,int id)
        {
            Category categoryToUpdate = _categoryDal.GetById(id);
            categoryToUpdate.Name = category.Name;
            _categoryDal.Update(categoryToUpdate,id);
        }

        public void Delete(DeleteCategoryRequest category)
        {
            Category deleteForCategory = new Category();
            deleteForCategory = _categoryDal.GetById(category.Id);
            _categoryDal.Delete(deleteForCategory);
        }

        public List<GetAllCategoryResponse> GetAll()
        {
            List<GetAllCategoryResponse> categoryList = new List<GetAllCategoryResponse>();

            foreach (var item in _categoryDal.GetAll())
            {
                categoryList.Add(new GetAllCategoryResponse { Id=item.Id,Name=item.Name});
            }
            return categoryList;
        }
    }
}
