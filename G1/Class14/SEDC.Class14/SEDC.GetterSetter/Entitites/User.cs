namespace SEDC.GetterSetter.Entitites
{
    public class User
    {
        private int _age;
        public string FullName { get; set; }
        public int Age
        {
            get
            {
                if (_age == 0)
                {
                    Console.WriteLine("No value for age");
                }
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Cannot have negative age value");
                }
                _age = value;
                Console.WriteLine("Value for Age set successfully!");
            }
        }

        public string Phone { get; private set; }

        private bool _isOld;
        public bool IsOld 
        { 
             get
            {
                return _age > 60;
            }
            set
            {
                _isOld = value;
            }
        }
    }



    // What compiler see
    public class UserNew
    {
        private string _fullName;

        public string FullName
        {
            get
            {
                return _fullName;
            }

            set
            {
                _fullName = value;
            }
        }


        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }
    }
}
