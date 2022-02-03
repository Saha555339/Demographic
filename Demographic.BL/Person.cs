using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demographic.FileOperations;

namespace Demographic.BL
{
    internal class Person
    {
        private int _max_age = 100;
        private int _age;
        public delegate void Not();
        public event Not ChildBirth;
        public int Age
        {
            get { return _age=_year-_yearOfBirth; }
        }
        public Sex.Gender Gender { get; set; }
        private int _yearOfBirth;
        public int YearOfBirth
        {
            get { return _yearOfBirth; }
            set { _yearOfBirth = value; }
        }
        private  int _yearOfDeath;
        public int YearOfDeath
        {
            get { return _yearOfDeath; }
            set { _yearOfDeath = value; }
        }
        private  int _year;
        public int Year
        {
            set { _year = value; }
        }
        private bool _isAlive;
        public bool IsAlive
        {
            get { return _isAlive; }
            set { _isAlive = value; }
        }
        private List<DeathRules> _deathRules = new List<DeathRules>();
        public List<DeathRules> deathRules
        {
            get { return _deathRules; }
            set { _deathRules = value; }
        }
        private const double _probabilityOfChild = 0.151;

        private void Child()
        {
            int ageOfChildA = 18;
            int ageOfChildB = 45;
            if (_isAlive && Gender == Sex.Gender.female && ProbabilityCalculator.IsEventHappened(_probabilityOfChild) && _age >= ageOfChildA && _age <= ageOfChildB)
                ChildBirth();
        }
        private void Death()
        {
            if (_age > _max_age)
            {
                _isAlive = false;
                _yearOfDeath = _year;
            }
            else
            {
                DeathRules death = _deathRules.Find(x => x.IntervalA <= _age && x.IntervalB >= _age);
                if (Gender == Sex.Gender.female && ProbabilityCalculator.IsEventHappened(death.VDeathWoman))
                {
                    _isAlive = false;
                    _yearOfDeath = _year;
                }
                if (Gender == Sex.Gender.male && ProbabilityCalculator.IsEventHappened(death.VDeathMan))
                {
                    _isAlive = false;
                    _yearOfDeath = _year;
                }
            }
        }
        public void NewYear(int year)
        {
            _year = year;
            _age = _year - _yearOfBirth;
            Death();
            Child();
        }
    }
}
