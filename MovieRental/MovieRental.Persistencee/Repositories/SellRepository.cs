using Microsoft.EntityFrameworkCore;
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
        private readonly MovieRentalDbContext _dbContext;

        public SellRepository(MovieRentalDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async  Task<bool> MovieExists(int id)
        {
            var movie =  await _dbContext.Movies.FindAsync(id);
            return movie != null;
        }

        public async Task<bool> MovieInStock(int id)
        {
            var movie = await _dbContext.Movies.FindAsync(id);
            return movie.Stock > 0;
        }

        public async  Task<Sell> Sell(Sell entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> UserExists(int id)
        {
            var user = await _dbContext.Users.FindAsync(id);
            return user != null;
        }
    }
}
