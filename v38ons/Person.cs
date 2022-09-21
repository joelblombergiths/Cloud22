namespace v38ons
{
    internal class Person
    {
        private string _firstName;
        public string FirstName 
        {
            get { return _firstName; }
            set { _firstName = value; }
        } 

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FullName {
            get { return $"{FirstName} {LastName}"; } 
            set
            {
                if (value.Contains(' '))
                {
                    string[] split = value.Split(' ');
                    _firstName = split[0];
                    _lastName = string.Join(" ", split[1..^0]);
                }
                else _firstName = value;
            }
        }

        private double _length;
        private double _weight;
        public double BMI => _weight / Math.Pow(_length, 2);


        public Person(string firstName, string lastName, double length, double weight)
        {
            _firstName = firstName;
            _lastName = lastName;
            _length = length;
            _weight = weight;
        }
    }
}
