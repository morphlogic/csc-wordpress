using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CSC.WordPress.Models;

namespace CSC.WordPress.Data
{
    public class CSCWordPressContext : DbContext
    {
        public CSCWordPressContext (DbContextOptions<CSCWordPressContext> options)
            : base(options)
        {
        }

        public DbSet<CSC.WordPress.Models.User> User { get; set; }
    }
}
