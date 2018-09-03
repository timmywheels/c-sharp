using System;

namespace Birthdate
{
    public class Person
    {
//        private DateTime _birthdate;
        public DateTime Birthdate { get; private set; }
        
        
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today = Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
        
//        public DateTime Birthdate
//        {
//            get { return _birthdate; }
//            set { _birthdate = value; }
//        }
        
        
//        public void SetBirthdate(DateTime birthdate)
//        {
//            this._birthdate = birthdate;
//        }
//
//        public DateTime GetBirthDate()
//        {
//            return _birthdate;
//        }
    }
}