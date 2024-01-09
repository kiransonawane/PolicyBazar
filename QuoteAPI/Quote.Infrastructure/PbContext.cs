using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Quote.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quote.Infrastructure
{
    public class PbContext : DbContext
    {
        public PbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<QuoteRequest> QuoteRequests { get; set; }

        
    }
}
