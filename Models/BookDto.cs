using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Models
{
    //class BookDto
    //{       

    //    public int Id { get; set; }
    //    public string Title { get; set; }
    //    public string Description { get; set; }
    //    public string Author { get; set; }
    //    public DateTime Created { get; set; }
    //    public int TotalQuantity { get; set; }
    //    public int AvailableQuantity { get; set; }
    //    public string Category { get; set; }
    //}

    public record BookDto(
        int Id,
        string Title,
        string Description,
        string Author,
        DateTime Created,
        int TotalQuantity,
        int AvailableQuantity,
        string Category
    );
}
