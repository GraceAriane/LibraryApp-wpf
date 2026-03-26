using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Models
{
    public record CreateBookDto
    {
        string Title;
        int AuthorId;
    }
}
