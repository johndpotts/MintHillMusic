namespace MintHillMusic.Migrations
{
    using MintHillMusic.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MintHillMusic.Models.MintHillMusicContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MintHillMusic.Models.MintHillMusicContext";
        }

        protected override void Seed(MintHillMusic.Models.MintHillMusicContext context)
        {

            context.Songs.AddOrUpdate(
                x => x.SongID,
                new Song() { SongID = 1, Name = "She'll be coming round the mountain", Genre = "Folk", Difficulty = "Beginner", ChordChart = "https://www.sheetmusic.com" },
                new Song() { SongID = 1, Name = "Jungle", Genre = "Rock", Difficulty = "Moderate", ChordChart = "https://www.sheetmusic.com" },
                new Song() { SongID = 1, Name = "Moonlight sonata", Genre = "Classical", Difficulty = "Advanced", ChordChart = "https://www.sheetmusic.com" },
                new Song() { SongID = 1, Name = "Call Me Maybe", Genre = "Pop", Difficulty = "Beginner", ChordChart = "https://www.sheetmusic.com" },
                new Song() { SongID = 1, Name = "Uncle Pen", Genre = "Folk", Difficulty = "Moderate", ChordChart = "https://www.sheetmusic.com" },
                new Song() { SongID = 1, Name = "Roar", Genre = "Pop", Difficulty = "Beginner", ChordChart = "https://www.sheetmusic.com" }
                                );
            
            
            
            
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
