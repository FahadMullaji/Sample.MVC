using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.MVC
{
    public class BenefitCalculator
    {
        public int ServiceCredits { get; set; }
        public int BenefitRate { get; set; }
        public int FAS { get; set; }
        public int CalculateBenefit() => ServiceCredits * BenefitRate * FAS;
    }
}
