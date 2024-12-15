using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Frisan_Ionut_Lab2.Models;

namespace Frisan_Ionut_Lab2.Data
{
    public class Frisan_Ionut_Lab2Context : DbContext
    {
        public Frisan_Ionut_Lab2Context (DbContextOptions<Frisan_Ionut_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Frisan_Ionut_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Frisan_Ionut_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Frisan_Ionut_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Frisan_Ionut_Lab2.Models.Category> Category { get; set; } = default!;
        public DbSet<Frisan_Ionut_Lab2.Models.Member> Member { get; set; } = default!;
        public DbSet<Frisan_Ionut_Lab2.Models.Borrowing> Borrowing { get; set; } = default!;
    }
}
