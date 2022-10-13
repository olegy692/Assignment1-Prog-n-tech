using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Prog_n_tech
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int Age { get; set; }
        public int ShirtNumber { get; set; }

        public override string ToString()
        {
            return Id + " " + Name + " " + Age + " " + ShirtNumber;
        }

        public void NameValidator()
        {
            if (Name == null)
            {
                throw new ArgumentNullException("Name should not be null");

            }

            if (Name.Length < 2)
            {
                throw new ArgumentException("Name should be at lease 2 characters long");

            }
        }

        public void AgeValidator()
        {
            if(Age <= 1)
            {
                throw new ArgumentOutOfRangeException("Age should be more than 1");
            }
        }


        public void ShirtNumberValidator()
        {
            if(ShirtNumber<=1 || ShirtNumber<=99)
            {
                throw new ArgumentOutOfRangeException("Shirt number should be between 1 and 99");
            }
        }


        public void Validate()
        {
            NameValidator();
            AgeValidator();
            ShirtNumberValidator();

        }
    }

    
}
