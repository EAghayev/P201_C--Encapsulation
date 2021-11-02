using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    class Student:Human
    {
        public void SetName(string name)
        {
            this._name = name;
        }
        public string GetName()
        {
            return this._name;
        }
    }
}
