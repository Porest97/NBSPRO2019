using System.ComponentModel.DataAnnotations;

namespace NBSPRO2019.Models.MutualModels
{
    public class PersonType
    {
        public int Id { get; set; }

        [Display(Name = "Person Type")]
        public string PersonTypeName { get; set; }
    }
}