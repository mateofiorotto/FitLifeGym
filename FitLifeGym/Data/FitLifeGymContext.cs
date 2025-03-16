using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FitLifeGym.Models;

namespace FitLifeGym.Data
{
    public class FitLifeGymContext : DbContext
    {
        public FitLifeGymContext (DbContextOptions<FitLifeGymContext> options)
            : base(options)
        {
        }

        public DbSet<FitLifeGym.Models.Product> Product { get; set; } = default!;
    }
}
