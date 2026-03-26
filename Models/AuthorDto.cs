using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Models
{
    public record AuthorDto
    {
        long Id;
        string Name;
        List<BookDto> Books;
    }
}
