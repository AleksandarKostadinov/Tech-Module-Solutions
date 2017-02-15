namespace _08.AverageGrades
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;

    class GradesWithFiles
    {
        static void Main()
        {
            var studentsInfo = File.ReadAllLines("input.txt");

            List<Student> students = new List<Student>();

            for (int i = 0; i < studentsInfo.Length; i++)
            {
                var tokens = studentsInfo[i]
                    .Split();
                var currentGrades = tokens
                    .Skip(1)
                    .Select(double.Parse)
                    .ToList();

                var currentStudentName = tokens[0];

                var currentStudent = new Student(currentStudentName, currentGrades);

                students.Add(currentStudent);
            }

            var exellentStudents = students
                .Where(s => s.AverageGrade() >= 5)
                .OrderByDescending(x => x.AverageGrade())
                .ToList();

            var output = new List<string>();

            foreach (var student in exellentStudents.OrderBy(c => c.Name))
            {
                output.Add($"{student.Name} -> {student.AverageGrade():f2}");
            }

            File.WriteAllLines("output.txt", output);
        }
    }
}
