using System.Collections.Generic;

namespace LibraryMgmtSystem
{
    public interface IIssuedBookData
    {
        System.DateTime DateOfIssue { get; }
        int To { get; }
        List<IBook> Books { get; }
    }
}