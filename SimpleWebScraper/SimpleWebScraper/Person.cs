using System;

namespace SimpleWebScraper
{
    class Person
    {
        private string _ssn;
        private string _passportData;
        private string _driversLicenseNumber;
        private string _firstName = "Tim";
        private string _lastName = "Wheeler";

        public Person(string ssn, string passportData, string driversLicenseNumber)
        {
            _ssn = ssn;
            _passportData = passportData;
            _driversLicenseNumber = driversLicenseNumber;
        }
        
        public bool HasProperDocuments
        {
            get { return _ssn.Length > 0 && _passportData.Length > 0 && _driversLicenseNumber.Length > 0; }
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (value.Length < 1)
                {
                    Console.WriteLine("Please enter a valid first name.");
                    return;
                }

                _firstName = value;
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (value.Length < 1)
                {
                    Console.WriteLine("Please enter a valid last name.");
                    return;
                }

                _lastName = value;
            }
        }
    }
}