using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        [Display(Name = "Favorite Genre")]
        public string FavoriteGenre { get; set; }

        [Display(Name = "Favorite Song")]
        public string FavoriteSong { get; set; }

        [Display(Name = "Customer Image")]
        public string Image { get; set; }

    }
}
