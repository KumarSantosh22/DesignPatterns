namespace DesignPattern.FluentInterface
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Student RollNo(int id)
        {
            Id = id;
            return this;
        }

        public Student NameOfStudent(string name)
        {
            Name = name;
            return this;
        }

        public Student MailTo(string email)
        {
            Email = email;
            return this;
        }

        public Student Callon(string phone)
        {
            Phone = phone;
            return this;
        }
    }
}
