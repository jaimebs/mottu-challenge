using MC.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Data.Context
{
    public class MCContext : DbContext
    {
        public MCContext(DbContextOptions options) : base(options) { }

        public DbSet<Motorcycle> Motorcycles { get; set; }
        public DbSet<DeliveryMan> DeliveryMan { get; set; }
    }
}
