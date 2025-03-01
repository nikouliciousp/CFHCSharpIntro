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
        public int Id { get => id; init => id = value; }
        public string? FirstName { get => firstName; init => firstName = value; }
        public string? LastName { get => lastName; init => lastName = value; }

        // Methods
        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName}";
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Student? student = obj as Student;
            return (Id == student?.Id)
                && (FirstName?.Equals(student.FirstName) ?? student.FirstName == null)
                && (LastName?.Equals(student.LastName) ?? student.LastName == null);
        }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            unchecked
            {
                // Overflow is fine, just wrap
                int hash = 17;
                hash = hash * 23 + Id.GetHashCode();
                hash = hash * 23 + (FirstName?.GetHashCode() ?? 0);
                hash = hash * 23 + (LastName?.GetHashCode() ?? 0);
                return hash;
            }
        }
    }
}
