using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOClone.Business.Dtos.Responses.TutorResponse
{
    public class GetByIdTutorResponse
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string TutorImageUrl { get; set; }
    }
}
