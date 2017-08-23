using System.Collections.Generic;

namespace LibraryMgmtSystem
{
    public interface IIssuedBookData
    {
        System.DateTime DateOfIssue { get; }
        System.Guid To { get; }
        List<IBook> Books { get; }
    }
}