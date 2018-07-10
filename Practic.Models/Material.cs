using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Practic.Models
{
    public class Material:Provider
    { 
        [Required]
        [Display(Name = "Материал")]
        public string Name { get; set; }
        public ICollection<Measure> Measures { get; set; }
        public Material()
        {
            Measures = new List<Measure>();
        }
    }
}