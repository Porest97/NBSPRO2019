using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NBSPRO2019.Models.MutualModels;

namespace NBSPRO2019.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<NBSPRO2019.Models.MutualModels.Company> Company { get; set; }
        public DbSet<NBSPRO2019.Models.MutualModels.PersonType> PersonType { get; set; }
        public DbSet<NBSPRO2019.Models.MutualModels.Person> Person { get; set; }
        public DbSet<NBSPRO2019.Models.MutualModels.Document> Document { get; set; }
    }
}
