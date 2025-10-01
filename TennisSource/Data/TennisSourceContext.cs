using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TennisSource.Models;

namespace TennisSource.Data
{
    public class TennisSourceContext : DbContext
    {
        public TennisSourceContext (DbContextOptions<TennisSourceContext> options)
            : base(options)
        {
        }

        public DbSet<TennisSource.Models.TennisTournament> TennisTournament { get; set; } = default!;
    }
}
