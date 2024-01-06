using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetInsta.Models;

namespace PetInsta.Data
{
    public class PetInstaContext : DbContext
    {
        public PetInstaContext (DbContextOptions<PetInstaContext> options)
            : base(options)
        {
        }

        public DbSet<PetInsta.Models.Pet> Pet { get; set; } = default!;
        public DbSet<PetInsta.Models.Post> Post { get; set; } = default!;
    }
}
