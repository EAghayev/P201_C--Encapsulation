using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    class Human
    {
        int no; //default private
        protected string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length > 2) _name = value;
            }
        }
        private string _surname;
        public string Surname
        {
            get => _surname;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length > 2) _surname = value;
            }
        }

        public string FullName
        {
            get
            {
                return Name + " " + Surname;
            }
        }


    }
}
