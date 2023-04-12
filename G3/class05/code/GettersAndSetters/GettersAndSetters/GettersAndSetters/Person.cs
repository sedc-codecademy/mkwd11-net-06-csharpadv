using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersAndSetters
{
    public class Person
    {
        private int _age;
        public int Age
        {
            get
            {
                //some another code can be writen here
                return _age * 2;
            }
            set
            {
                _age = value + 5;
            }
        }

        private string _name;     
        public string Name
        {
            get => _name;
            protected set => _name = value;
        }

    }
}
