using System;

namespace School
{
    public class Class
    {
        public static string Name;
        public static string IdNumber;
        public string NameOfCourse;

        public int NumberOfExcercises;
        public int NumberOfClasses;

       
    }
    public class Student:Class
    {
        public string StudentName
        {
            get { return Name; }
            set { Name = "Anne"; }
        }
        public string StudentIdNumber
        {
            get { return IdNumber; }
            set { IdNumber = "345A19G"; }
        }
    }

    public class Teachers:Class 
    {
        public string TeachersName
        {
            get { return Name; }
            set { Name = "Gilbert"; }
        }
        public string Course
        {
            set { Course = "Chemistry"; }
        }
    }
    public class Course:Class
    {
        public string NameofCourse
        {
            get { return NameOfCourse; }
            set { NameOfCourse = "Biology"; }
        }
        public int NumberOfExercise
        {
            get { return NumberOfExercise; }
            set { NumberOfExercise = 6; }
        }
        public int NumberofClasses
        {
            get { return NumberOfClasses; }
            set { NumberOfClasses = 3; }
        }
        class program
        {
            public void Main()
            {
                Console.WriteLine(" ");
                Console.WriteLine();
            }
        }
    }
}
