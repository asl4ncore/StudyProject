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
        [Display(Name = "Дата/Время начала работ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy  hh:mm }", ApplyFormatInEditMode = true)]
        public DateTime JobTime { get; set; }
        [Display(Name = "Машина подрядчика")]
        public bool MachineContractor { get; set; }
        [Display(Name = "№ машины")]
        public int MachineId { get; set; }
        public Machine Machine { get; set; }
        [Display(Name = "ТипМаршрута")]
        public int RouteTypeId { get; set; }
        public RouteType RouteType { get; set; }
        [Display(Name = "Материал")]
        public int MaterialId { get; set; }
        public Material Material { get; set; }
        [Display(Name = "Маршрут")]
        public int RouteId { get; set; }
        public Route Route { get; set; }
        [Display(Name = "Определение тары")]
        public int DetermineId { get; set; }
        public Determine Determine { get; set; }
        [Display(Name = "Тип работ")]
        public int JobTypeId { get; set; }
        public JobType JobType { get; set; }
    }
}
