using DomainModels;
using Services;
using System;

namespace AcademyApp
{
    class Program
    {
        static void Main(string[] args)
        {


            AcademyService academyService = new AcademyService();

            //Student isko = academyService.CreateStudent("Ivica","",25,12351);

            Student max = academyService.CreateStudent("Max", "Harper", 25, 288210);
            Student ashton = academyService.CreateStudent("Ashton", "Tucker", 27, 288210);
            Student carl = academyService.CreateStudent("Carl", "Alexander", 28, 288210);
            Student albert = academyService.CreateStudent("Albert", "Thomas", 21, 288210);
            Student kevin = academyService.CreateStudent("Kevin", "Turner", 30, 288210);
            Student charlotte = academyService.CreateStudent("Charlotte", "Mitchell", 27, 288210);
            Student sawyer = academyService.CreateStudent("Sawyer", "Baker", 21, 288210);
            Student savana = academyService.CreateStudent("Savana", "Holmes", 25, 288210);

            Student[] jsBasicStudents = new Student[] { max, ashton, charlotte, savana };
            Student[] jsAdvancedStudents = new Student[] { max, sawyer, kevin, ashton, savana };

            

            // Subjects
            Subject htmlCss = new Subject("HTML/CSS", 10);
            Subject javaScriptBasic = new Subject("Basic JavaScript", 10, jsBasicStudents);
            Subject javaScriptAdvanced = new Subject("Advanced JavaScript", 15, jsAdvancedStudents);
            Subject cSharpBasic = new Subject("Basic C#", 10);
            Subject cSharpAdvanced = new Subject("Advanced C#", 15);

            Subject[] webSubjects = new Subject[] { htmlCss, javaScriptBasic, javaScriptAdvanced, cSharpBasic };

            // Academy
            Academy web = new Academy("Web", "Full Stack Web Development", webSubjects);

            // AcademyService
            academyService.StartAcademy(web);
            academyService.AddSubjectToAcademy(web, cSharpAdvanced);
            academyService.AddStudentToSubject(cSharpAdvanced, max);
            academyService.AddStudentToSubject(cSharpAdvanced, carl);
            academyService.AddStudentToSubject(cSharpAdvanced, albert);
            academyService.StartSubject(web, "HTML/CSS");



        

            Console.ReadLine();
        }
    }
}
