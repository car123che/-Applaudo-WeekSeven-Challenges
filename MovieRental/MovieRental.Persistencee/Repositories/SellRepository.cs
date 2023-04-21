using MovieRental.Application.Pesistence.Contracts;
using MovieRental.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Persistence.Repositories
{
    public class SellRepository : ISellRepository
    {
        public Task<Sell> Sell(Sell entity)
        {
            throw new NotImplementedException();
        }
    }
}
