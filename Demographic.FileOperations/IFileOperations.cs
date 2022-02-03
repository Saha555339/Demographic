using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic.FileOperations
{
    internal interface IFileOperations
    {
        void ReadDeathRules(string path);
        void ReadInitialAge(string path);
        string[] FileParser(string path);
    }
}
