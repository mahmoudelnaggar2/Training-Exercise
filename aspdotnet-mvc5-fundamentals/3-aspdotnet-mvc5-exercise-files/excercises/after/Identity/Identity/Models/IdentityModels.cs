﻿using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Identity.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string FavoriteBook { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }

    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }


    }
}