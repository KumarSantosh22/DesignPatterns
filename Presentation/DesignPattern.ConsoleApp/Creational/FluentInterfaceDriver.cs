using DesignPattern.FluentInterface;

namespace DesignPattern.ConsoleApp.Creational
{
    // Driver Code
    public class FluentInterfaceDriver
    {
        public void Drive()
        {
            FluentEmployee employee = new FluentEmployee();
            employee.NameOfTheEmployee("Santosh Kumar")
                .BornOn(Convert.ToDateTime("22-09-1997"))
                .WrorkingInDepartment("PE")
                .StaysAt("Hyderabad");

            Employee emp = employee.GetEmployee();

            Console.WriteLine($"Name: {emp.FullName}\nDOB: {emp.DateOfBirth}\nDepartment: {emp.Department}\nAddress: {emp.Address}\n");

            Student student = new Student();
            student.RollNo(1).NameOfStudent("Santosh Kumar").MailTo("santosh@gmail.com").Callon("870000XXXX");
            Console.WriteLine($"Name: {student.Name}\nRollNo: {student.Id}\nEmail: {student.Email}\nPhone: {student.Phone}\n");
        }
    }
}
