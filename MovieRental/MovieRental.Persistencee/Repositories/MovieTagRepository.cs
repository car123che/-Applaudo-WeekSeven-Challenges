using MovieRental.Application.Pesistence.Contracts;
using MovieRental.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Persistence.Repositories
{
    public class MovieTagRepository : IMovieTagRepository
    {
        public Task<MovieTag> Add(MovieTag entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(MovieTag entity)
        {
            throw new NotImplementedException();
        }
    }
}
