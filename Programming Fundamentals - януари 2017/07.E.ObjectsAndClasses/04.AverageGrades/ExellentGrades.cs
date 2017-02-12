namespace _04.AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ExellentGrades
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split();
                var currentGrades = input
                    .Skip(1)
                    .Select(double.Parse)
                    .ToList();

                var currentStudentName = input[0];

                var currentStudent = new Student(currentStudentName, currentGrades);

                students.Add(currentStudent);
            }

            var exellentStudents = students
                .Where(s => s.AverageGrade() >= 5)
                .OrderByDescending(x => x.AverageGrade())
                .ToList();

            foreach (var student in exellentStudents.OrderBy(c => c.Name))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade():f2}");
            }
        }
    }
}
