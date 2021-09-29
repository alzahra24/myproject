using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students_Challenge.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<Student> student { get; set; }

    public DbSet<classes> classes { get; set; }

    public DbSet<countries> countries { get; set; }

    }




}

