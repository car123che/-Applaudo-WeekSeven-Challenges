﻿using Moq;
using MovieRental.Application.Pesistence.Contracts;
using MovieRental.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Application.UnitTests.Mocks
{
    public class MockTagRepository
    {
        public static Mock<ITagRepository> GetTagRepository()
        {
            var Tags = new List<Tag>
            {
                new Tag{ Id = 1, Name = "Accion"},
                new Tag{ Id = 2, Name = "Aventura"}
            };

            var mockRepo = new Mock<ITagRepository>();

            // Obtener todas
            mockRepo.Setup(r => r.GetAll()).ReturnsAsync(Tags);

            // Agregar una
            mockRepo.Setup(r => r.Add(It.IsAny<Tag>())).ReturnsAsync((Tag tag) =>
            {
                Tags.Add(tag);
                return tag;
            });


            return mockRepo;
        }
    }
}
