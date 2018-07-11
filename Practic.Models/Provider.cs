using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Practic.Models
{
    public class Provider
    {
        public int Id { get; set; }
        [Display(Name = "Имя поставщика")]
        public string ProviderName { get; set; }
        [Display(Name = "Страна поставщика")]
        public string ProviderCountry { get; set; }
        public List<Material> Material { get; }

        public Provider()
        {
            Material = new List<Material>();
        }
    }
}
