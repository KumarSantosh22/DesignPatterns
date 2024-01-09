namespace DesignPattern.FluentInterface
{
    public class FluentEmployee
    {
        private Employee employee = new Employee();

        public FluentEmployee NameOfTheEmployee(string fullName)
        {
            employee.FullName = fullName;
            return this;
        }

        public FluentEmployee BornOn(DateTime dob)
        {
            employee.DateOfBirth = dob;
            return this;
        }

        public FluentEmployee WrorkingInDepartment(string department)
        {
            employee.Department = department;
            return this;
        }

        public FluentEmployee StaysAt(string address)
        {
            employee.Address = address;
            return this;
        }

        public Employee GetEmployee()
        {
            return employee;
        }
    }
}

/*
 * The Fluent Interface Design Pattern in C# is a way of implementing object-oriented APIs in a manner that
 * aims to provide more readable and discoverable code. It often involves Method Chaining,
 * where each method returns the same context object, invoking multiple actions or commands in a single line of code.  
 * 
 * Method Chaining in C# is a common technique where each method returns an object,
 * and all these methods can be chained together to form a single statement.
 * 
 * The core idea behind the Fluent Interface pattern is to make code more readable and
 * to make the client code look like a domain-specific language.
 * 
 * The Fluent Interface Design Pattern’s main objective is to apply multiple properties (or methods)
 * to an object by connecting them with dots (.) without re-specifying the object name each time.
 * 
 * Creating such interfaces is like speaking a sentence that would make the class consumption code more simple and readable.
 */
