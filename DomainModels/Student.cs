namespace DomainModels
{
    public class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int CardNumber { get; set; }
        public Subject CurrentSubject { get; set; }

    }
}
