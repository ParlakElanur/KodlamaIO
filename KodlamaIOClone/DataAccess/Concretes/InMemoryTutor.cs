using KodlamaIOClone.DataAccess.Abstracts;
using KodlamaIOClone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOClone.DataAccess.Concretes
{
    public class InMemoryTutor : ITutorDal
    {
        List<Tutor> tutors = new List<Tutor>();
        public InMemoryTutor()
        {
            tutors.Add(new Tutor() { Id = 1, FullName = "Engin Demiroğ", TutorImageUrl = "blah blah" });
            tutors.Add(new Tutor() { Id = 2, FullName = "Gençay Yıldız", TutorImageUrl = "blah blah" });
        }

        public Tutor GetById(int id)
        {
            Tutor? tutor = tutors.Where(t => t.Id == id).SingleOrDefault();
            return tutor;
        }
        public void Add(Tutor tutor)
        {
            tutors.Add(tutor);
        }
        public void Update(Tutor tutor, int tutorID)
        {
            Tutor? tutorToUpdate = tutors.Where(t => t.Id == tutorID).SingleOrDefault();
            tutorToUpdate.FullName = tutor.FullName;
            tutorToUpdate.TutorImageUrl = tutor.TutorImageUrl;
        }

        public void Delete(Tutor tutor)
        {
            tutors.Remove(tutor);
        }
        public List<Tutor> GetAll()
        {
            return tutors;
        }

    }
}
