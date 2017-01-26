using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additonal Namespaces
using Chinook.Data.Entities;
using Chinook.Data.DTOs;
using ChinookSystem.DAL;
using System.ComponentModel;
using Chinook.Data.POCOs;
#endregion
namespace ChinookSystem.BLL
{
    [DataObject]
    public class AlbumController
    {
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<AlbumArtist> ListAlbumsbyArtist()
        {
            using (var context = new ChinookContext())

            {
                var results = from x in context.Albums
                              orderby x.Artist.Name
                              select new AlbumArtist
                              {
                                  Artist = x.Artist.Name,
                                  Title = x.Title,
                                  ReleaseYear = x.ReleaseYear,
                                  ReleaseLabel = x.ReleaseLabel
                              };
                return results.ToList();
            }

        }




        [DataObjectMethod(DataObjectMethodType.Select, false)]

        public List<Album> Albums_GetForArtistbyName(string name)
        {
            using (var context = new ChinookContext())
            {
                var results = context.Albums
                    .Where(x => x.Artist.Name.Contains(name))
                    .OrderByDescending(x => x.ReleaseYear);
                return results.ToList();
            }
        }



        [DataObjectMethod(DataObjectMethodType.Select,false)]

        public List<ArtistAlbumRelease> ArtistAlbumRelease_List()
        {
            using (var context = new ChinookContext())
            {
                var results = from x in context.Albums
                              group x by x.Artist.Name into result
                              select new ArtistAlbumRelease
                              {
                                  Artist = result.Key,
                                  Albums = (from y in result
                                            select new AlbumRelease
                                            {
                                                Title = y.Title,
                                                Ryear = y.ReleaseYear,
                                                Label = y.ReleaseLabel

                                            }).ToList()
                              };
                return results.ToList();

            }
            

        }

    }
}
