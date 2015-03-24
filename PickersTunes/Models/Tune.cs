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

        public Tune(string tuneName, string artist= "", string albumName= "", string userId= "")
        {
            if (userId == "")
            {
                this.ApplicationUserId = System.Web.HttpContext.Current.User.Identity.GetUserId();
            }
            else
            {
                this.ApplicationUserId = userId;
            }
            this.Name = tuneName;
            this.Album = "";
        }

        public Tune(string tuneName)
        {
            this.ApplicationUserId = System.Web.HttpContext.Current.User.Identity.GetUserId();
            this.Artist = "";
            this.Name = tuneName;
            this.Album = "";
        }

/*
        public Tune(string ArtistName, string TuneName, string AlbumName, string UserId)
        {
            this.ApplicationUserId = UserId;
            this.Artist = ArtistName;
            this.Name = TuneName;
            this.Album = AlbumName;
        }
*/

        public event PropertyChangedEventHandler PropertyChanged;
    }
}