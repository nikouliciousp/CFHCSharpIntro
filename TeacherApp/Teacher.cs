using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherApp
{
    /// <summary>
    /// Represents a teacher.
    /// </summary>
    internal class Teacher
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        // The Address property is of type Address, which is defined in the same namespace.
        public Address? Address { get; set; }

        /// <summary>
        /// Creates a copy of the teacher.
        /// </summary>
        /// <returns></returns>
        public Teacher GetCopyReference()
        {
            return this;
        }

        /// <summary>
        /// Creates a shallow copy of the teacher.
        /// </summary>
        /// <returns></returns>
        public Teacher GetShallowCopy()
        {
            Teacher newTeacher = (Teacher)this.MemberwiseClone();
            newTeacher.Address = this.Address; // Ensure the Address reference is copied
            return newTeacher;
        }

        /// <summary>
        /// Creates a deep copy of the teacher.
        /// </summary>
        /// <returns></returns>
        public Teacher GetDeepCopy()
        {
            // Create a new Teacher object and copy the values from the original Teacher object.
            Teacher newTeacher = (Teacher)this.MemberwiseClone();

            // Create a new Address object and copy the values from the original Address object.
            newTeacher.Address = new Address
            {
                Street = this.Address?.Street,
                City = this.Address?.City,
                State = this.Address?.State,
                Zip = this.Address?.Zip
            };
            return newTeacher;
        }

        /// <summary>
        /// Initializes a new instance of the Teacher class.
        /// </summary>
        /// <param name="teacher"></param>
        public Teacher(Teacher teacher)
        {
            Id = teacher.Id;
            FirstName = teacher.FirstName;
            LastName = teacher.LastName;
            Address = new Address
            {
                Street = teacher.Address?.Street,
                City = teacher.Address?.City,
                State = teacher.Address?.State,
                Zip = teacher.Address?.Zip
            };
        }

        public Teacher()
        {
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{FirstName} {LastName} Address: {Address?.Street}, {Address?.City}, {Address?.State}, {Address?.Zip} Memory Address: {GetHashCode()}";
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, FirstName, LastName, Address?.Street, Address?.City, Address?.State, Address?.Zip);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            return obj is Teacher teacher &&
                   Id == teacher.Id &&
                   FirstName == teacher.FirstName &&
                   LastName == teacher.LastName &&
                   EqualityComparer<Address?>.Default.Equals(Address, teacher.Address);
        }
    }
}
