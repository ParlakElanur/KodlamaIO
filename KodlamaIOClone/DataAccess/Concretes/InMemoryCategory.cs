using KodlamaIOClone.DataAccess.Abstracts;
using KodlamaIOClone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOClone.DataAccess.Concretes
{
    public class InMemoryCategory : ICategoryDal
    {
        List<Category> categories = new List<Category>();

        public InMemoryCategory()
        {
            categories.Add(
                new Category 
                { 
                    Id=1,
                    Name = "Programlama 1",
                });
            categories.Add(
                new Category
                {
                    Id = 2,
                    Name = "Programlama 2",
                });
            categories.Add(
                new Category
                {
                    Id = 3,
                    Name = "Programlama 3",
                });
        }

        public Category GetById(int id)
        {
            Category? category = categories.Where(c => c.Id == id).FirstOrDefault();
            return category;
        }
        public void Add(Category category)
        {
            categories.Add(category);
        }
        public void Update(Category category,int categoryID)
        {
            Category categoryToUpdate = GetById(category.Id);
            categoryToUpdate.Name = category.Name;
        }
        public void Delete(Category category)
        {
            categories.Remove(category);
        }
        public List<Category> GetAll()
        {
            return categories;
        }
        
    }
}
