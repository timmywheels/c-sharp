namespace BuilderPattern
{
    public class PersonBuilder
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private string _eyeColor;
        private string _hairColor;

        public PersonBuilder()
        {
            SetDefaults();
        }

        public void SetDefaults()
        {
            _firstName = "Tim";
            _lastName = "Wheeler";
            _age = 27;
            _eyeColor = "Blue";
            _hairColor = "Brown";

        }

        public PersonBuilder WithFirstName(string firstName)
        {
            _firstName = firstName;
            return this;
        }
        
        public PersonBuilder WithLastName(string lastName)
        {
            _lastName = lastName;
            return this;
        }
        
        public PersonBuilder WithAge(int age)
        {
            _age = age;
            return this;
        }
        
        public PersonBuilder WithEyeColor(string eyeColor)
        {
            _eyeColor = eyeColor;
            return this;
        }
        
        public PersonBuilder WithHairColor(string hairColor)
        {
            _hairColor = hairColor;
            return this;
        }

        public Person Build()
        {
            var person = new Person(_firstName, _lastName, _age, _eyeColor, _hairColor);
            return person;
        }
    }
}