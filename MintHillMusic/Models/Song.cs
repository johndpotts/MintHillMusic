using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MintHillMusic.Models
{
    public class Song
    {
        public int SongID { get; set; }

        public string Name { get; set; }

        public string Genre { get; set; }

        public string Difficulty { get; set; }

        public string ChordChart { get; set; }
    }
}