using System;
using _22School.Interfaces;

namespace _22School.Models
{
    public abstract class Person : IPerson
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The first name must not be null or empty.");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The first name must not be null or empty.");
                }

                this.lastName = value;
            }
        }

        public Person(string firstName,string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
