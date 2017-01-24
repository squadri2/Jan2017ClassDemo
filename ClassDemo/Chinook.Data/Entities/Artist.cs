using System;
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
    [Table("Artists")]           
    public class Artist
    {   
        [Key]
        public int ArtistId { get; set; }
        public string Name { get; set; }

        //navigational Properties
        //the virtual property Albums point to all children of the parent instance
        //Icollection Parent to child
        public virtual ICollection<Album> Albums { get; set; }
    }
}
