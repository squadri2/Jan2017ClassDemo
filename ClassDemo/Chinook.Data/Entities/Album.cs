﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namesapaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#endregion

namespace Chinook.Data.Entities
{
    [Table("Albums")]
    public class Album
    {
        [Key]

        public int AlbumId { get; set; }
        public string Title { get; set; }
        public int ArtistId { get; set; }
        public int ReleaseYear { get; set; }
        public string ReleaseLabel { get; set; }


        //navigational Properties
        //here Child Point to parent.
        public virtual Artist Artist { get; set; }

    }
}
