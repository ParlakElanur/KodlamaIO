using KodlamaIOClone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOClone.DataAccess.Abstracts
{
    public interface ITutorDal
    {
        void Add(Tutor tutor);
        Tutor GetById(int id);
        List<Tutor> GetAll();
        void Update(Tutor tutor);
        void Delete(Tutor tutor);
    }
}
