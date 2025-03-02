namespace TeacherApp
{
    /// <summary>
    /// Represents a teacher.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Address = new Address
                {
                    Street = "123 Main St",
                    City = "Anytown",
                    State = "AS",
                    Zip = "12345"
                }
            };

            // Create a deep copy of the teacher.
            Teacher newTeacher = teacher.GetDeepCopy();
            newTeacher.Id = 1;
            newTeacher.FirstName = "Jane";
            newTeacher.LastName = "Smith";
            newTeacher.Address = new Address
            {
                Street = "456 Elm St",
                City = "Othertown",
                State = "OS",
                Zip = "54321"
            };

            // Display the original teacher.
            Console.WriteLine("Original Teacher:");
            Console.WriteLine(teacher.ToString());

            // Display the new teacher.
            Console.WriteLine("Deep Copy of Teacher:");
            Console.WriteLine(newTeacher.ToString());

            // Create a shallow copy of the teacher.
            Teacher shallowCopy = teacher.GetShallowCopy();
            shallowCopy.Id = 2;
            shallowCopy.FirstName = "Alice";
            shallowCopy.LastName = "Jones";
            shallowCopy.Address.Street = "789 Oak St";
            shallowCopy.Address.City = "Another Town";
            shallowCopy.Address.State = "AT";
            shallowCopy.Address.Zip = "54321";

            // Display the shallow copy of the teacher.
            Console.WriteLine("Shallow Copy of Teacher:");
            Console.WriteLine(shallowCopy.ToString());

            // Display the original teacher.
            Console.WriteLine("Original Teacher:");
            Console.WriteLine(teacher.ToString());
        }
    }
}
