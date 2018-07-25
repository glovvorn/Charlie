using System;
using System.Collections.Generic;
using System.Text;

namespace Charlie.Interfaces
{
    public interface IFileTest
    {
        string GetFilename();
        string GetFilepath();
        string ParseMetadata();

    }
}
