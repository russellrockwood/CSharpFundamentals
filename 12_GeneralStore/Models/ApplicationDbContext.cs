﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _12_GeneralStore.Models
{
    public class ApplicationDbContext : DbContext
    {
        // Tell our ApplicationDbContext how to connect to our localSQL database
        public ApplicationDbContext() : base("DefaultConnection") { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        
    }
}