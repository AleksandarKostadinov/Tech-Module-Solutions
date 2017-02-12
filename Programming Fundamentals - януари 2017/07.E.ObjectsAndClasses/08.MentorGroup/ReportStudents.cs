namespace _08.MentorGroup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    class ReportStudents
    {
        static void Main()
        {
            var students = new SortedDictionary<string, Student>();

            var nameAndDateInfo = Console.ReadLine();

            while (nameAndDateInfo != "end of dates")
            {
                var tokens = nameAndDateInfo
                    .Split();
                var studentName = tokens[0];

                var studentInfo = new Student();
                studentInfo.datesAttended = new List<DateTime>();
                studentInfo.comments = new List<string>();

                if (tokens.Length > 1 )
                {
                    var attended = tokens[1]
                        .Split(',')
                        .Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                        .ToList();
                    studentInfo.datesAttended.AddRange(attended);
                }

                if (students.ContainsKey(studentName))
                {
                    students[studentName].datesAttended.AddRange(studentInfo.datesAttended);
                }
                else
                {
                    students[studentName] = studentInfo;
                }

                nameAndDateInfo = Console.ReadLine();
            }

            var commentInfo = Console.ReadLine();

            while (commentInfo != "end of comments")
            {
                var tokens = commentInfo
                    .Split('-');
                var currentStudentName = tokens[0];
                var comment = tokens[1];

                if (students.ContainsKey(currentStudentName))
                {
                    students[currentStudentName].comments.Add(comment);
                }

                commentInfo = Console.ReadLine();
            }

            foreach (var user in students)
            {
                Console.WriteLine(user.Key);
                Console.WriteLine("Comments:");
                user.Value.comments
                    .ForEach(x => Console.WriteLine($"- {x}"));
                Console.WriteLine("Dates attended:");
                user.Value.datesAttended
                    .OrderBy(y => y)
                    .ToList()
                    .ForEach(z => Console.WriteLine($"-- {z:dd/MM/yyyy}"));
                    
            }
        }
    }
}
