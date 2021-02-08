using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCodingAssessment.Models;
using Microsoft.EntityFrameworkCore;

namespace CCodingAssessment.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Transfer> Transfers { get; set; }
        public DbSet<Bond> Bonds { get; set; }
        public DbSet<Indemnitor> Indemnitors { get; set; }
        public DbSet<ProvidingAgency> ProvidingAgencies { get; set; }
        public DbSet<RequestingAgency> RequestingAgencies { get; set; }
        public DbSet<Defendant> Defendants { get; set; }
        public DbSet<Jail> Jails { get; set; }
    }
}
