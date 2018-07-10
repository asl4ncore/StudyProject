using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Practic.Models
{
    public class RouteType
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Тип маршрута")]
        public string Name { get; set; }
        public ICollection<Measure> Measures { get; set; }
        public RouteType()
        {
            Measures = new List<Measure>();
        }
    }
}