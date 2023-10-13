using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD_2.Models;

namespace CRUD_2.Data
{
    public class CRUD_2Context : DbContext
    {
        public CRUD_2Context (DbContextOptions<CRUD_2Context> options)
            : base(options)
        {
        }

        public DbSet<CRUD_2.Models.User> User { get; set; } = default!;
    }
}
