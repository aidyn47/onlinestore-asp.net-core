using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Models;

namespace OnlineStore.Data
{
    public class OnlineStoreContext : DbContext
    {
        public OnlineStoreContext (DbContextOptions<OnlineStoreContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineStore.Models.Store> Store { get; set; } = default!;

        public DbSet<OnlineStore.Models.Users> Users { get; set; } = default!;
    }
}
