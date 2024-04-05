using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Core.Domain
{
    public class Rental
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public decimal TotalCost { get; set; }
        public Motorcycle Motorcycle { get; set; }
        public DeliveryMan DeliveryMan { get; set; }
        public RentalPlan RentalPlan { get; set; }
    }
}
