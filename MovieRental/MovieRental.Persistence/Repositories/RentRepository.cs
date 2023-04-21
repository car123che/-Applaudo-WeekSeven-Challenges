using MovieRental.Application.Pesistence.Contracts;
using MovieRental.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Persistence.Repositories
{
    public class RentRepository : IRentRepository
    {
        public Task<Rent> Rent(Rent entity)
        {
            throw new NotImplementedException();
        }

        public Task Return(Rent entity)
        {
            throw new NotImplementedException();
        }
    }
}
