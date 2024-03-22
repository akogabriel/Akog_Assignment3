using System;

namespace Akog_Assignment3
{
    public class Person : BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName = "", string lastName = "")
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override bool IsValidated()
        {
            // If FirstName or LastName is null, assign an empty string
            if (FirstName == null)
            {
                FirstName = "";
            }

            if (LastName == null)
            {
                LastName = "";
            }

            // Return true if both FirstName and LastName have non-zero length
            return !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName);
        }
    }

}
