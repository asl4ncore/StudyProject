using System.ComponentModel.DataAnnotations;

namespace Practic.Models
{
    public class Add : Measure
    {
        [Range(0, 100, ErrorMessage = "Неверное количество партии!")]
        [Display(Name = "Партии")]
        public int Consignment { get; set; }
    }
}
