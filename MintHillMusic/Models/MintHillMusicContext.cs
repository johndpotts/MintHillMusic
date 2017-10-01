using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MintHillMusic.Models
{
    public class MintHillMusicContext : DbContext
    {
        
public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
