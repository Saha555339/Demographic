using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demographic.WinForms.View;
using Demographic.FileOperations;
using Demographic.BL;

namespace Demographic.WinForms.Presentation
{
    internal class DemPresentation
    {
        Engine engine = new Engine();
        FOperations file_operations = new FOperations();
        private IDemView demView;
        public DemPresentation(IDemView view)
        {
            demView = view;
        }
        public void DataChecking(string YStart, string YEnd, string IPop)
        {
            try
            {
                demView.YearStart = Convert.ToInt32(YStart);
                demView.YearEnd = Convert.ToInt32(YEnd);
                demView.InitPop = Convert.ToInt64(IPop);
            }
            catch (Exception)
            {
                throw new Exception("Некорректный тип начальных данных");
            }
            if (demView.InitPop <= 0)
                throw new Exception("Некорректная начальная популяция");
            else if (demView.YearStart < 0)
                throw new Exception("Некорректный год начала моделирования");
            else if (demView.YearEnd < 0)
                throw new Exception("Некорректный год конца моделирования");
            else if (demView.YearEnd < demView.YearStart)
                throw new Exception("Год конца моделирования больше, чем год начала");
        }
        public void FileParse()
        {
            file_operations.ReadDeathRules(demView.PathDeathRules);
            file_operations.ReadInitialAge(demView.PathInitialAge);
        }
        public void Modeling()
        {
            engine.Initial(file_operations.Arr_InitialAge, file_operations.Arr_DeathRules, demView.InitPop, demView.YearStart, demView.YearEnd);
            engine.Moddelling();
            demView.YearPopulation = engine.YearPopulation;
            demView.Male_Population = engine.Male_Population;
            demView.Female_Population = engine.Female_Population;

            demView.FemaleFinalPopulation = engine.FemaleEnd;
            demView.MaleFinalPopulation = engine.MaleEnd;
        }
    }
}
