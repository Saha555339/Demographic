using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Demographic.FileOperations
{
    public class FOperations : IFileOperations
    {
        private List<DeathRules> _arrDeath = new List<DeathRules>();
        private List<InitialAge> _arrInitAge = new List<InitialAge>();
        public List<DeathRules> Arr_DeathRules
        {
            get { return _arrDeath; }
        }
        public List<InitialAge> Arr_InitialAge
        {
            get { return _arrInitAge; }
        }
        IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
        public string[] FileParser(string path)
        {
            const int file_length_byte = 1024 * 1024;
            string[] Arr;
            System.IO.FileInfo file = new System.IO.FileInfo(path);
            if (path != null)
            {
                if (!(path.EndsWith(".csv")))
                    throw new Exception("Некорректный тип файла");
                else
                {
                    if (file.Length > file_length_byte)
                        throw new Exception("Некорректный размер файла");
                    else
                    {
                        Arr = File.ReadAllLines(path);
                        if (Arr[0] == "")
                            throw new Exception("Файл пуст");
                    }
                }
            }
            else
                throw new Exception("Путь файла не загружен");
            return Arr;
        }
        /// <summary>
        /// Считывание таблицы смертности
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <exception cref="Exception"></exception>
        public void ReadDeathRules(string path)
        {
            string[] _arrD;
            const int kol_char = 4;
            _arrD = FileParser(path);
            for (int i = 1; i < _arrD.Length; i++)
            {
                int IA;
                int IB;
                double VDM;
                double VDW;
                string[] s = _arrD[i].Split(',');
                if (s.Length != kol_char)
                    throw new Exception($"Некорректное содержание файла в {i} строке");
                else
                {
                    try
                    {
                        IA = Convert.ToInt32(s[0]);
                        IB = Convert.ToInt32(s[1]);
                        VDM = double.Parse(s[2], formatter);
                        VDW = double.Parse(s[3], formatter);
                    }
                    catch (Exception)
                    {
                        throw new Exception($"Некорректный тип характеристик в таблице смертности в {i} строке в файле DeathRules ");
                    }
                    _arrDeath.Add(new DeathRules { IntervalA = IA, IntervalB = IB, VDeathMan = VDM, VDeathWoman = VDW });
                }
            }
        }
        /// <summary>
        /// Считывание файла начальных данных
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <exception cref="Exception"></exception>
        public void ReadInitialAge(string path)
        {
            const int kol_char = 2;
            string[] _arrI;
            _arrI = FileParser(path);
            for (int i = 1; i < _arrI.Length; i++)
            {
                int age;
                double kol;
                string[] s = _arrI[i].Split(',');
                if (s.Length != kol_char)
                    throw new Exception($"Некорректный тип характеристик в файле с возрастным составом населения в {i} строке");
                else
                {
                    try
                    {
                        age = Convert.ToInt32(s[0]);
                        kol = double.Parse(s[1], formatter);
                    }
                    catch (Exception)
                    {
                        throw new Exception($"Некоректный тип характеристик в {i} строке в файле InitialAge");
                    }
                    _arrInitAge.Add(new InitialAge { Age = age, Kol = kol });
                }
            }
        }
    }
}
