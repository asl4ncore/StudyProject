using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic.Models
{
    public abstract class Measure 
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Дата/Время начала работ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy  hh:mm }", ApplyFormatInEditMode = true)]
        public DateTime JobTime { get; set; }

        public abstract class Machine
        {
            [Required]
            [Display(Name = "Машина подрядчика")]
            public bool MachineContractor { get; set; }

            [Required]
            [Display(Name = "№ машины")]
            public string MachineNumber { get; set; }
        }

        [Required]
        [Display(Name = "ТипМаршрута")]
        public int RouteTypeId { get; set; }
        public RouteType RouteType { get; set; }

        [Required]
        [Display(Name = "Материал")]
        public int MaterialId { get; set; }
        public Material Material { get; set; }

        [Required]
        [Display(Name = "Маршрут")]
        public int RouteId { get; set; }
        public Route Route { get; set; }

       
        [Required]
        [Display(Name = "Определение тары")]
        public int DetermineId { get; set; }
        public Determine Determine { get; set; }

        [Required]
        [Display(Name = "Тип работ")]
        public int JobTypeId { get; set; }
        public JobType JobType { get; set; }
    }
}
