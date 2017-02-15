namespace _08.AverageGrades
{
    using System.Collections.Generic;
    using System.Linq;

    class Student
    {
        public string Name { get; set; }

        public List<double> Grades { get; set; }

        public Student(string name, List<double> grades)
        {
            Name = name;
            Grades = grades;
        }

        public double AverageGrade()
        {
            return this.Grades.Average();
        }
    }
}
