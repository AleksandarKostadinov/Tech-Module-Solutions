namespace _10.StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class AssignmentOfGroups
    {
        public static void Main()
        {
            List<Town> towns = ReadTownsAndStudents();

            List<Group> groups = DistributeStudentsToGroups(towns);

            Console.WriteLine($"Created {groups.Count} groups in {towns.Count} towns:");

            foreach (var group in groups.OrderBy(g => g.Town.Name))
            {
                var groupsTownName = group.Town.Name;
                var emailsInGroup = new List<string>();

                foreach (var student in group.Students)
                {
                    emailsInGroup.Add(student.Email);
                }

                Console.WriteLine("{0} => {1}", group.Town.Name, string.Join(", ", emailsInGroup));
            }
        }

        static List<Group> DistributeStudentsToGroups(List<Town> towns)
        {
            var groups = new List<Group>();

            foreach (var orderedTown in towns.OrderBy(t => t.Name))
            {
                var students = orderedTown.Students
                    .OrderBy(s => s.RegistrationDate)
                    .ThenBy(u => u.Name)
                    .ThenBy(g => g.Email)
                    .ToList();

                while (students.Any())
                {
                    var group = new Group();
                    group.Town = orderedTown;
                    group.Students = students
                        .Take(orderedTown.SeatsCount)
                        .ToList();
                    students = students
                        .Skip(group.Town.SeatsCount)
                        .ToList();
                    groups.Add(group);
                }
            }

            return groups;
        }

        static List<Town> ReadTownsAndStudents()
        {
            var towns = new List<Town>();

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                if (line.Contains("=>"))
                {
                    var tokens = line
                        .Split("=>".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                    var townName = tokens[0].Trim();
                    var seatsCount = int.Parse(tokens[1].Substring(0,tokens[1].LastIndexOf("seats")).Trim());

                    var currentTown = new Town();

                    currentTown.Name = townName;
                    currentTown.SeatsCount = seatsCount;
                    currentTown.Students = new List<Student>();

                    towns.Add(currentTown);
                }
                else
                {
                    var studentInfo = line
                        .Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                    var studentName = studentInfo[0].Trim();
                    var studentEmail = studentInfo[1].Trim();
                    var studentRegistrationDate = DateTime.ParseExact(studentInfo[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);

                    var currentStudent = new Student();

                    currentStudent.Name = studentName;
                    currentStudent.Email = studentEmail;
                    currentStudent.RegistrationDate = studentRegistrationDate;

                    towns[towns.LastIndexOf(towns.Last())].Students.Add(currentStudent);
                }
            }

            return towns;
        }
    }
}
