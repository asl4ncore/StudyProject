using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Practic.Models
{
    public class Determine
    {
        public int Id { get; set; }
        [Display(Name = "Определение тары")]
        public string Name { get; set; }
        public ICollection<Measure> Measures { get; set; }

        public Determine()
        {
            Measures = new List<Measure>();
        }
    }
}