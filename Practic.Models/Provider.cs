using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Practic.Models
{
    public class Provider
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Имя поставщика")]
        public string ProviderName { get; set; }

        [Required]
        [Display(Name = "Страна поставщика")]
        public string ProviderCountry { get; set; }
    }
}
