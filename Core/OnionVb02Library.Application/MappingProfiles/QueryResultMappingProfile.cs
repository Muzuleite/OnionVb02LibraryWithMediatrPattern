using AutoMapper;
using OnionVb02Library.Application.Mediatrs.Results.AuthorResults;
using OnionVb02Library.Application.Mediatrs.Results.BookResults;
using OnionVb02Library.Application.Mediatrs.Results.CategoryResults;
using OnionVb02Library.Application.Mediatrs.Results.TagResults;
using OnionVb02Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02Library.Application.MappingProfiles
{
    public class QueryResultMappingProfile:Profile
    {
        public QueryResultMappingProfile()
        {
            CreateMap<Category, GetCategoryByIdQueryResult>().ReverseMap();
            CreateMap<Category, GetCategoryQueryResult>().ReverseMap();

            // Author Results
            CreateMap<Author, GetAuthorByIdQueryResult>().ReverseMap();
            CreateMap<Author, GetAuthorQueryResult>().ReverseMap();

            // Book Results
            CreateMap<Book, GetBookByIdQueryResult>().ReverseMap();
            CreateMap<Book, GetBookQueryResult>().ReverseMap();

            // Tag Results
            CreateMap<Tag, GetTagByIdQueryResult>().ReverseMap();
            CreateMap<Tag, GetTagQueryResult>().ReverseMap();
        }
       
    }
}
