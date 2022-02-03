using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demographic.FileOperations;

namespace Demographic.BL
{
    public class Engine : IEngine
    {
        private const int _age1 = 0;
        private const int _age2 = 18;
        private const int _age3 = 45;
        private const int _age4 = 65;
        private const int _agemax = 100;

        private double _probabilityOfGirl = 0.55;
        public int YearTek { get; set; }
        public int YearStart { get; set; }
        public int YearEnd { get; set; }
        private List<int> _femaleEnd = new List<int>();
        public List<int> FemaleEnd
        {
            get { return _femaleEnd; }
            set { _femaleEnd = value; }
        }
        private List<int> _maleEnd = new List<int>();
        public List<int> MaleEnd
        {
            get { return _maleEnd; }
            set { _maleEnd = value; }
        }
        private List<Person> _persons = new List<Person>();
        private List<DeathRules> Deathrules { get; set; }
        private List<InitialAge> initAge { get; set; }
        private List<int> _yPop = new List<int>();
        public List<int> YearPopulation
        {
            get { return _yPop; }
        }
        private List<int> _mPop = new List<int>();
        public List<int> Male_Population
        {
            get { return _mPop; }
        }
        private List<int> _fPop = new List<int>();
        public List<int> Female_Population
        {
            get { return _fPop; }
        }

        public delegate void Notif(int year);
        public event Notif YearTick;

        public void Initial(List<InitialAge> initage, List<DeathRules> initDeath, long init_pop, int ystart, int yend)
        {
            const int k = 1000;
            const int kol_genders = 2;
            YearStart = ystart;
            YearEnd = yend;
            Deathrules = initDeath;
            initAge = initage;
            foreach(var init in initAge)
            {
                for (int i = 0; i < (((init.Kol / kol_genders / k) * init_pop)/k); i++)
                {
                    Person male = new Person { Gender = Sex.Gender.male, deathRules = Deathrules, IsAlive = true, YearOfBirth = YearStart - init.Age, Year = YearStart };
                    Person female = new Person { Gender = Sex.Gender.female, deathRules = Deathrules, IsAlive = true, YearOfBirth = YearStart - init.Age, Year = YearStart };
                    female.ChildBirth += ChildBirh;
                    YearTick += female.NewYear;
                    YearTick += male.NewYear;
                    _persons.Add(male);
                    _persons.Add(female);
                }
            }
        }
        private void CurrentYear(int year)
        {
            YearTek = year;
            YearTick(year);
            int Male = (from i in _persons where i.IsAlive && i.Gender == Sex.Gender.male select i).Count();
            int Female = (from i in _persons where i.IsAlive && i.Gender == Sex.Gender.female select i).Count();
            _yPop.Add(Male + Female);
            _mPop.Add(Male);
            _fPop.Add(Female);
        }

        public void Moddelling()
        {
            for(int i=YearStart;i<=YearEnd;i++)
            {
                CurrentYear(i);
            }
            CalculateFinalPopulation();
            /*for (int i = 0; i < _persons.Count; i++)
            {
                _persons[i].ChildBirth -= ChildBirh;
                YearTick -= _persons[i].NewYear;
            }*/
        }
        private void ChildBirh()
        {
            Person person = new Person { IsAlive = true, YearOfBirth = YearTek, deathRules = Deathrules };
            YearTick += person.NewYear;
            if (ProbabilityCalculator.IsEventHappened(_probabilityOfGirl))
            {
                person.ChildBirth += ChildBirh;
                person.Gender = Sex.Gender.female;
            }
            else
            {
                person.Gender = Sex.Gender.male;
            }
            _persons.Add(person);
        }
        private void CalculateFinalPopulation()
        {
            int fem = (from i in _persons where i.IsAlive && i.Gender == Sex.Gender.female && i.Age >= _age1 && i.Age <= _age2 select i).Count();
            _femaleEnd.Add(fem);
            fem = (from i in _persons where i.IsAlive && i.Gender == Sex.Gender.female && i.Age >= _age2+1 && i.Age <= _age3 select i).Count();
            _femaleEnd.Add(fem);
            fem = (from i in _persons where i.IsAlive && i.Gender == Sex.Gender.female && i.Age >= _age3 && i.Age <= _age4 select i).Count();
            _femaleEnd.Add(fem);
            fem = (from i in _persons where i.IsAlive && i.Gender == Sex.Gender.female && i.Age >= _age4 && i.Age <= _agemax select i).Count();
            _femaleEnd.Add(fem);

            int male = (from i in _persons where i.IsAlive && i.Gender == Sex.Gender.male && i.Age >= _age1 && i.Age <= _age2 select i).Count();
            _maleEnd.Add(male);
            male = (from i in _persons where i.IsAlive && i.Gender == Sex.Gender.male && i.Age >= _age2+1 && i.Age <= _age3 select i).Count();
            _maleEnd.Add(male);
            male = (from i in _persons where i.IsAlive && i.Gender == Sex.Gender.male && i.Age >= _age3 && i.Age <= _age4 select i).Count();
            _maleEnd.Add(male);
            fem = (from i in _persons where i.IsAlive && i.Gender == Sex.Gender.male && i.Age >= _age4 && i.Age <= _agemax select i).Count();
            _maleEnd.Add(male);
        }
        
    }
}
