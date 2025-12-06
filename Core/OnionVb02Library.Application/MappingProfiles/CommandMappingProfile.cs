using AutoMapper;
using OnionVb02Library.Application.Mediatrs.Commands.AuthorCommands;
using OnionVb02Library.Application.Mediatrs.Commands.BookCommands;
using OnionVb02Library.Application.Mediatrs.Commands.TagCommands;
using OnionVb02Library.Application.Mediatrs.Commands.BookTagCommands;
using OnionVb02Library.Domain.Models;

namespace OnionVb02Library.Application.MappingProfiles
{
    public class CommandMappingProfile : Profile
    {
        public CommandMappingProfile()
        {
            // Category
            CreateMap<CreateCategoryCommand, Category>().ReverseMap();
            CreateMap<UpdateCategoryCommand, Category>().ReverseMap();

            // Author
            CreateMap<CreateAuthorCommand, Author>().ReverseMap();
            CreateMap<UpdateAuthorCommand, Author>().ReverseMap();

            // Book
            CreateMap<CreateBookCommand, Book>().ReverseMap();
            CreateMap<UpdateBookCommand, Book>().ReverseMap();

            // Tag
            CreateMap<CreateTagCommand, Tag>().ReverseMap();
            CreateMap<UpdateTagCommand, Tag>().ReverseMap();

            // BookTag (idler composite oldugu için sadece create map yeterli)
            CreateMap<CreateBookTagCommand, BookTag>().ReverseMap();
        }
    }
}
