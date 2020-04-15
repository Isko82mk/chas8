namespace DomainModels
{
    public class Academy
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Subject[] Subjects { get; set; }
        public bool IsStarted { get; set; }


        public Academy(string aName, string aDescription, Subject[] subjects)
        {
            Name = aName;
            Description = aDescription;
            Subjects = subjects;
            IsStarted = false;

        }



    }


}
