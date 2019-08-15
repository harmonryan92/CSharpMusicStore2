using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }

        [Display(Name = "Release Date")]        //Changes display from releasedate to release date
        [DataType(DataType.Date)]               //changes the datetime object to a date object
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyy}", ApplyFormatInEditMode = false)] //sets the formatting for the date
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

        [Display(Name = "Album Art")]           //Changes display from imagepath to album art
        public string ImagePath { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public bool IsActive { get; set; }
        public bool IsFeatured { get; set; }
    }
}
