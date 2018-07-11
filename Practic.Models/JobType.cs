using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Practic.Models
{
    public class JobType
    {
        public int Id { get; set; }
        [Display(Name = "Тип работ")]
        public string Name { get; set; }
        public ICollection<Measure> Measures { get; set; }

        public JobType()
        {
            Measures = new List<Measure>();
        }
    }
}