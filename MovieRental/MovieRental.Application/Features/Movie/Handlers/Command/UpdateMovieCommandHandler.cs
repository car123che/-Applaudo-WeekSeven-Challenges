﻿using AutoMapper;
using MediatR;
using MovieRental.Application.Features.Movie.Requests.Command;
using MovieRental.Application.Pesistence.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Application.Features.Movie.Handlers.Command
{
    public class UpdateMovieCommandHandler : IRequestHandler<UpdateMovieCommand, Unit>
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;

        public UpdateMovieCommandHandler(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateMovieCommand request, CancellationToken cancellationToken)
        {
            var movie = await _movieRepository.Get(request.MovieDto.Id);
            if (movie == null)
                throw new Exception("NOT FOUND EXCEPTION nameof(LeaveType), request.LeaveTypeDto.Id");


            _mapper.Map(request.MovieDto, movie);
            await _movieRepository.Update(movie);

            return Unit.Value;
        }
    }
}
