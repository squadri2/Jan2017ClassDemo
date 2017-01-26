﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#region Addition NameSpaces

using Chinook.Data.POCOs;
#endregion

namespace Chinook.Data.DTOs
{
    public class ArtistAlbumRelease
    {
        public string Artist { get; set; }
        public List<AlbumRelease> Albums { get; set; }
    }
}
