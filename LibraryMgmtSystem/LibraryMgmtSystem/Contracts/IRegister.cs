﻿using System.Collections.Generic;

namespace LibraryMgmtSystem
{
    public interface IRegister
    {
        List<IIssuedBookData> IssuedBooks { get; set; }
    }
}