using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace PickersTunes.Models
{
    public class Tune
    {
        public int TuneId { get; set; }
        public string Artist { get; set; }
        public string Name { get; set; }
        public string Album { get; set; }
        public string ApplicationUserId { get; set; }

        public Tune()
        {
            // placeholder
        }

        public Tune(string tuneName, string userId="")
        {
            if (userId == "")
            {
                this.ApplicationUserId = "Harry Jones";
            }
            else
            {
                this.ApplicationUserId = userId;
            }
            this.Name = tuneName;
            this.Album = "";
        }

        public Tune(string tuneName, string artist, string albumName, string userId)
        {
            this.Name = tuneName;
            this.Artist = artist;
            this.Album = albumName;
            this.ApplicationUserId = userId;
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}