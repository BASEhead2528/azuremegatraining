using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AzureMegaTraining.Models;

namespace AzureMegaTraining.DAL
{
    public class DBContext : DbContext
    {
        public DbSet<CacheTestData> MyProperty { get; set; }
    }
}