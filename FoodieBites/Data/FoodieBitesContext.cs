using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FoodieBites.Models;


namespace FoodieBites.Data
{
    public class FoodieBitesContext : DbContext
    {
        public FoodieBitesContext (DbContextOptions<FoodieBitesContext> options)
            : base(options)
        {
        }

        public DbSet<FoodieBites.Models.Forum> Forum { get; set; } = default!;
    }
}
