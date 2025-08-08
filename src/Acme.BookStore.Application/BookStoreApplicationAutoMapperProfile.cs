using Acme.BookStore.Authors;
using Acme.BookStore.Books;
using AutoMapper;

namespace Acme.BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();//put to application layer
        CreateMap<BookDto, Book>();//put to domain
        CreateMap<CreateUpdateBookDto, Book>(); //put to
        CreateMap<Author, AuthorDto>();// put to application layer
        CreateMap<Author, AuthorLookupDto>();

    }
}
