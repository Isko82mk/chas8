namespace DomainModels
{
    public class Subject
    {


        public string Name { get; set; }
        public int Classes { get; set; }
        public Student[] Students { get; set; }
        public bool isStarted { get; set; }




        public Subject(string aName, int aClasses)
        {
            Name = aName;
            Classes = aClasses;

            Students = new Student[] { };/// vo zadachata se bara parametar da bide empty array.

            isStarted = false;

        }

        public Subject(string aName, int aClasses, Student[] students)
        {
            Name = aName;
            Classes = aClasses;
            Students = students;
            isStarted = false;


        }



    }






}
