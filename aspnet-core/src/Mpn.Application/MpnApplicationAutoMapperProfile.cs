using AutoMapper;
using Mpn.Dtos;
using Mpn.Models;

namespace Mpn
{
    public class MpnApplicationAutoMapperProfile : Profile
    {
        public MpnApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Book, BookDto>();
            CreateMap<CreateUpdateBookDto, Book>();

            CreateMap<TestT4, TestT4Dto>();
            CreateMap<CreateUpdateTestT4Dto, TestT4>();

        }
    }
}
