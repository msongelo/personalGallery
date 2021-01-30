using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PersonalGallery.Models;

namespace PersonalGallery.Data
{
    public class PersonalGalleryContext : DbContext
    {
        public PersonalGalleryContext (DbContextOptions<PersonalGalleryContext> options)
            : base(options)
        {
        }

        public DbSet<PersonalGallery.Models.ImageModel> ImageModel { get; set; }
    }
}
