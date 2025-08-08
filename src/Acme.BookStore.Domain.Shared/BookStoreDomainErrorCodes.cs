namespace Acme.BookStore;

public static class BookStoreDomainErrorCodes
{
    public const string AuthorAlreadyExists = "BookStore:00001";
}
//Whenever you throw an AuthorAlreadyExistsException,
//the end user will see a nice error message on the UI.