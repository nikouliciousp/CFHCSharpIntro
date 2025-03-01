using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    /// <summary>
    /// A simple <c>Student</c> POCO class.
    /// </summary>
    class Student
    {
        // Fields
        private int id;
        private string? firstName;
        private string? lastName;

        // Properties
        public int Id { get => id; set => id = value; }
        public string? FirstName { get => firstName; set => firstName = value; }
        public string? LastName { get => lastName; set => lastName = value; }

        // Methods
        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName}";
        }
    }
}
