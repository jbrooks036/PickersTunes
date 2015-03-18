﻿using System;
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
        public string UserId { get; set; }

        public Tune()
        {
            // placeholder
        }

        public Tune(string TuneName)
        {
            this.Artist = "";
            this.Name = TuneName;
            this.Album = "";
        }

        public Tune(string ArtistName, string TuneName, string AlbumName)
        {
            this.UserId = System.Web.HttpContext.Current.User.Identity.GetUserId();
            this.Artist = ArtistName;
            this.Name = TuneName;
            this.Album = AlbumName;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}