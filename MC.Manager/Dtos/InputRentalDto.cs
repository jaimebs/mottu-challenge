using MC.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Manager.Dtos
{
    public class InputRentalDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public decimal TotalCost { get; set; }
        public int MotorcycleId { get; set; }
        public int DeliveryManId { get; set; }
        public int RentalPlanId { get; set; }

    }
}
