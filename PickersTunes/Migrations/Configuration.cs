namespace PickersTunes.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using PickersTunes.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<PickersTunes.TuneContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "PickersTunes.TuneContext";
        }

        protected override void Seed(PickersTunes.TuneContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Tunes.AddOrUpdate( i => i.Name, 
                new Tune
                {
                    Name = "Foggy Mountain Breakdown",
                    UserId = "Mary Rose",
                    Artist = "Scruggs and Flatt",
                    Album = "Scruggs and Flatt"
                },
            
                new Tune
                {
                    Name = "You the One",
                    UserId = "Mary Rose",
                    Artist = "Kathy Mattea",
                    Album = "Wild Rose"
                },
            
                new Tune
                {
                    Name = "Keep on the Sunny Side",
                    UserId = "Jennifer Iris",
                    Artist = "Robin Flower",
                    Album = "First Album"
                },
            
                new Tune
                {
                    Name = "Tickle Me",
                    UserId = "Jennifer Iris",
                    Artist = "Robin Flower",
                    Album = "First Album"
                }
            
            );            
        }
    }
}
