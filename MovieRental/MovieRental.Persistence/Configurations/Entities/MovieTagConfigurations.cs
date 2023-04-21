using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRental.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Persistence.Configurations.Entities
{
    public class MovieTagConfigurations : IEntityTypeConfiguration<Sell>
    {
        public void Configure(EntityTypeBuilder<Sell> builder)
        {

            // SEEDING DATA
            builder.HasData(
                   new Sell { Id = 1, MovieId = 1, TagId = 1 },
                   new Sell { Id = 2, MovieId = 1, TagId = 2 },
                   new Sell { Id = 3, MovieId = 2, TagId = 1 },
                   new Sell { Id = 4, MovieId = 2, TagId = 2 },
                   new Sell { Id = 5, MovieId = 3, TagId = 3 },
                   new Sell { Id = 6, MovieId = 4, TagId = 6 }
                   );


        }
    }
}
