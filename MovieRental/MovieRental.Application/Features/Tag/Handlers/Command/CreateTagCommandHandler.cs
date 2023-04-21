using AutoMapper;
using MediatR;
using MovieRental.Application.DTOs.Tag.Validators;
using MovieRental.Application.Features.Tag.Requests.Command;
using MovieRental.Application.Pesistence.Contracts;

namespace MovieRental.Application.Features.Tag.Handlers.Command
{
    public class CreateTagCommandHandler : IRequestHandler<CreateTagCommand, int>
    {
        private readonly ITagRepository _tagRepository;
        private readonly IMapper _mapper;

        public CreateTagCommandHandler(ITagRepository tagRepository, IMapper mapper)
        {
            _tagRepository = tagRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateTagDtoValidator();
            var validationResult = await validator.ValidateAsync(request.TagDto);

            if (validationResult.IsValid == false)
                throw new Exception("new validation exception");

            var tag = _mapper.Map<MovieRental.Domain.Tag>(request.TagDto); //map from the DTO to the domain type
            tag = await _tagRepository.Add(tag);


            return tag.Id;
        }
    }
}
