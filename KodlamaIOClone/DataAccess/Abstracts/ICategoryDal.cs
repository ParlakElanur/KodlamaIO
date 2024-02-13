using KodlamaIOClone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOClone.DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        void Add(Category category);
        Category GetById(int id);
        List<Category> GetAll();
        void Update(Category category);
        void Delete(Category category);

    }
}
