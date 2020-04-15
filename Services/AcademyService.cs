using DomainModels;
using System;

namespace Services
{
    public class AcademyService
    {
        public void StartAcademy(Academy academy)
        {
            if (!academy.IsStarted)
            {
                Console.WriteLine(academy.IsStarted = true);
            }
        }
        public void EndAcademy(Academy academy)
        {
            if (academy.IsStarted)
            {
                academy.IsStarted = false;

            }
        }
        public void StartSubject(Academy academy, string subjectName)
        {

            foreach (Subject subject in academy.Subjects)
            {
                if (subject.Name == subjectName)
                {

                    if (subject.isStarted)
                    {
                        subject.isStarted = true;
                    }

                    foreach (Student student in subject.Students)
                    {
                        student.CurrentSubject = subject;
                    }

                }
            }


        }
        public void EndSubject(Academy academy, string subjectName)
        {

            foreach (Subject subject in academy.Subjects)
            {
                if (subject.Name == subjectName)
                {
                    if (!subject.isStarted)
                    {
                        subject.isStarted = false;
                    }
                }
            }



        }
        public void AddStudentToSubject(Subject subject, Student student)
        {
            if (subject != null && student != null)
            {
                Student[] students = subject.Students;
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
                subject.Students = students;

            }


        }
        public void AddSubjectToAcademy(Academy academy, Subject subject)
        {
            if (academy != null && subject != null)
            {

                Subject[] subjects = academy.Subjects;
                Array.Resize(ref subjects, subjects.Length + 1);
                subjects[subjects.Length - 1] = subject;
                academy.Subjects = subjects;

            }
        }
        public Student CreateStudent(string name, string lastName, int age, int cardNumber)
        {
            Student student = new Student();
            student.Name = name;
            student.LastName = lastName;
            student.Age = age;
            student.CardNumber = cardNumber;

            return student;
        }

    }
}
