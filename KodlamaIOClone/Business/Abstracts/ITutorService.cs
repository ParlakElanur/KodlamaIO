using KodlamaIOClone.Business.Dtos.Requests.TutorRequest;
using KodlamaIOClone.Business.Dtos.Responses.TutorResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOClone.Business.Abstracts
{
    public interface ITutorService
    {
        GetByIdTutorResponse GetById(int id);
        void Add(AddTutorRequest tutor);
        void Update(UpdateTutorRequest tutor);
        void Delete(DeleteTutorRequest tutor);
        List<GetAllTutorResponse> GetAll();
    }
}
