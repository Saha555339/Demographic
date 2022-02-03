using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demographic.FileOperations;

namespace Demographic.BL
{
    internal interface IEngine
    {
        int YearTek { get; set; }
        int YearStart { get; set; }
        int YearEnd { get; set; }
        List<int> YearPopulation { get; }
        List<int> Male_Population { get; }
        List<int> Female_Population { get; }
        void Initial(List<InitialAge> initage, List<DeathRules> initDeath, long init_pop, int ystart, int yend);
        void Moddelling();

    }
}
