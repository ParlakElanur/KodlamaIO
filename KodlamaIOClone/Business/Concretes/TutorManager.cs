using KodlamaIOClone.Business.Dtos.Requests;
using KodlamaIOClone.Business.Dtos.Requests.TutorRequest;
using KodlamaIOClone.Business.Dtos.Response;
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
    public class TutorManager
    {
        ITutorDal _tutorDal;
        public TutorManager(ITutorDal tutorDal)
        {
            _tutorDal = tutorDal;
        }
        public GetByIdTutorResponse GetById(int id)
        {
            GetByIdTutorResponse getByIdTutorResponse = new GetByIdTutorResponse();

            Tutor tutor = _tutorDal.GetById(id);
            getByIdTutorResponse.Id = tutor.Id;
            getByIdTutorResponse.FullName = tutor.FullName;
            getByIdTutorResponse.TutorImageUrl = tutor.TutorImageUrl;

            return getByIdTutorResponse;
        }
        public void Add(AddTutorRequest tutor)
        {
            Random rnd = new Random();

            Tutor dtoToTutor = new Tutor();
            dtoToTutor.Id= (int)rnd.NextInt64(0, 100);
            dtoToTutor.FullName = tutor.FullName;

            _tutorDal.Add(dtoToTutor);
        }
        public void Update(UpdateTutorRequest tutor,int tutorID)
        {
            Tutor tutorToUpdate = new Tutor();

            tutorToUpdate.FullName = tutor.FullName;
            tutorToUpdate.TutorImageUrl = tutor.TutorImageUrl;

            _tutorDal.Update(tutorToUpdate, tutorID);
        }
        public void Delete(DeleteTutorRequest tutor)
        {
            Tutor deleteToTutor = new Tutor();

            deleteToTutor = _tutorDal.GetById(tutor.Id);
            _tutorDal.Delete(deleteToTutor);
        }
        public List<GetAllTutorResponse> GetAll()
        {
            List<GetAllTutorResponse> tutorList = new List<GetAllTutorResponse>();

            foreach (var item in _tutorDal.GetAll())
            {
                tutorList.Add(new GetAllTutorResponse { Id = item.Id, FullName = item.FullName });
            }
            return tutorList;
        }

    }
}
