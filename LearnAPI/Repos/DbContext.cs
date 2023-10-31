using System;
using System.Collections.Generic;
using LearnAPI.Repos.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnAPI.Repos
{
    public class LearnAPIDbContext : DbContext
    {

        public LearnAPIDbContext(DbContextOptions<LearnAPIDbContext> options): base(options)
        {
        }
        public DbSet<TblLearnAPICustomer> TblCustomers { get; set; }
        public DbSet<TblProduct> TblProducts { get; set; }
    }
}
