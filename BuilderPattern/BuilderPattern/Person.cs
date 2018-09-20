namespace BuilderPattern
{
    public class Person
    {
        public Person(string FirstName, string LastName, int Age, string EyeColor, string HairColor)
        {

            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.EyeColor = EyeColor;
            this.HairColor = HairColor;

        }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string EyeColor { get; set; }
        public string HairColor { get; set; }
        
        
    }
}