using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Practic.Models
{
    public class Material:Provider
    { 
        [Display(Name = "Материал")]
        public string Name { get; set; }
        public ICollection<Measure> Measures { get; set; }
        [Display(Name = "Тип работ")]
        public int ProviderId { get; set; }
        public Provider Provider { get; set; }

        public Material()
        {
            Measures = new List<Measure>();
        }
    }
}