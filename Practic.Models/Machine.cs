using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic.Models
{
    public  class Machine
    {
        public int Id { get; set; }
        [Display(Name = "№ машины")]
        public string Name { get; set; }
        public string Type { get; set; }
        public string Driver { get; set; }
        public string Manufactor { get; set; }
        public ICollection<Measure> Measures { get; set; }

        public Machine()
        {
            Measures = new List<Measure>();
        }

    }
}
