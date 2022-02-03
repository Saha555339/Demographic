using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demographic.FileOperations;

namespace Demographic.WinForms.View
{
    public interface IDemView
    {
        int YearStart { get; set; }
        long InitPop { get; set; }
        int YearEnd { get; set; }
        List<int> MaleFinalPopulation { get; set; }
        List<int> FemaleFinalPopulation { get; set; }
        string PathInitialAge { get; set; }
        string PathDeathRules { get; set; }
        List<int> YearPopulation { get; set; }
        List<int> Male_Population { get; set; }
        List<int> Female_Population { get; set; }
    }
}
