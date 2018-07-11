using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Practic.Models
{
    public class Route
    {
        public int Id { get; set; }
        [Display(Name = "Маршрут")]
        public string Name { get; set; }

        public ICollection<Measure> Measures { get; set; }
        public Route()
        {
            Measures = new List<Measure>();
        }
    }

    public class RouteFrom:Route
    {
        [Required]
        [Display(Name = "Откуда")]
        public new string Name { get; set; }

    }
    public class RouteTo : Route
    {
        [Required]
        [Display(Name = "Куда")]
        public new string Name { get; set; }
    }
}