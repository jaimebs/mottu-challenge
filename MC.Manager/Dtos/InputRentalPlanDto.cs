using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Manager.Dtos
{
    public class InputRentalPlanDto
    {
        public string Name { get; set; }
        public int DurationInDays { get; set; }
        public decimal DailyCost { get; set; }
    }
}
