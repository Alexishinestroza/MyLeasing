﻿using Microsoft.EntityFrameworkCore;
using Myleasing.Web.Data.Entities;
using MyLeasing.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Myleasing.Web.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
             
        public DbSet<Owner> Owners { get; set; }
             
        public DbSet<Contract> Contracts { get; set; }
             
        public DbSet<Lessee> lessees { get; set; }

        public DbSet<Property> Propeties { get; set; }

        public DbSet<PropertyImage> PropertyImages { get; set; }

        public DbSet<PropertyType> PropertyTypes { get; set; }

    }

    
}
