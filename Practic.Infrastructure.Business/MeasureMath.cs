using Practic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practic.Models;

namespace Practic.Infrastructure.Business
{
    public class MeasureMath : IMeasure
    {
        public int FirstWeighFull { get; set; }
        public double FirstWeighPacking { get; set; }
        public int SecondWeighFull { get; set; }
        public double SecondWeighPacking { get; set; }

        public  void FirstMeasure(Weigh weigh)
        {
            this.FirstWeighFull = weigh.WeighFull;
            this.FirstWeighPacking = weigh.WeighPacking;

        }

        public void SecondMeasure(Weigh weigh)
        {
            this.SecondWeighFull = weigh.WeighFull;
            this.SecondWeighPacking = weigh.WeighPacking;
        }
        public void SelectMeasure(Weigh weigh)
        {
           if (weigh.WeighDetermine==true) { SecondMeasure(weigh); }
            if (weigh.WeighDetermine == false) { FirstMeasure(weigh); }
        }
        public void Total(Weigh weigh)
        {
            weigh.WeighMaterial = this.SecondWeighFull-this.SecondWeighPacking-this.FirstWeighFull-this.FirstWeighPacking;
        }
    }
}
