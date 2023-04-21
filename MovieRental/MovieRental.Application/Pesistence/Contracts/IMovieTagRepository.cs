using MovieRental.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Application.Pesistence.Contracts
{
    public interface IMovieTagRepository
    {
        Task<Sell> Add(Sell entity);
        Task Delete(Sell entity);
    }
}
