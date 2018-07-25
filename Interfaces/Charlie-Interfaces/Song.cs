using Charlie.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Charlie.Interfaces
{
    public class Song : FileTest, IFileTest
    {
        public string GetFilename() => FileName;
        
        public string GetFilepath()
        {
            return Path;
        }

        public string ParseMetadata()
        {
            // custom logicks
            return MetaData;
        }
    }
}
