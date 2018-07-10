using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Practic.Models
{
    public class Weigh:Measure
    {
        [Required]
        [Display(Name = "Весоизмерение")]
        public int WeighFull { get; set; }
        [Required]
        [Display(Name = "Вес упаковки")]
        public double WeighPacking { get; set; }
        [Required]
        [Display(Name = "Вес материала(нетто)")]
        public double? WeighMaterial { get; set; }
        [Required]
        [Display(Name = "Тип")]
        public bool WeighType { get; set; }
        [Required]
        [Display(Name = "Определение тары")]
        public bool WeighDetermine { get; set; }
        [Required]
        [Display(Name = "Загрезненость")]
        public int WeighContamination { get; set; }
       
    }
   
}

