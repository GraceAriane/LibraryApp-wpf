using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Models
{
    public record LoanDto
    {
        string UserName;
        string BookTitle;
        DateTime LoanDate;
        DateTime ExpectedReturnDate;
        LoanStatus Status;
        Double Penalty;

    }
}
