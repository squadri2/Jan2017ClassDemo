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
    [Table("Tracks")]
    public class Track
    {
        [Key]

        public int TrackId { get; set; }

        public string Name { get; set; }

        public int? AlbumId { get; set; }
        public int MediaTypeId { get; set; }

        public int GenreId { get; set; }
         
        public int Composer { get; set; }

        public int Milliseconds { get; set; }
        public int? Bytes { get; set; }
        public decimal UnitPrice { get; set; } 


        public virtual Album Album { get; set; }

        public virtual MediaType MediaTypes { get; set; }





    }
}
