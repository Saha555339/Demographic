using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic.FileOperations
{
    internal interface IDeathRules
    {
        int IntervalA { get; set; }
        int IntervalB { get; set; }
        double VDeathMan { get; set; }
        double VDeathWoman { get; set; }
    }
}
