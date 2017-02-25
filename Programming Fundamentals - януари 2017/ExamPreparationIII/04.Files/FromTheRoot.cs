namespace _04.Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class FromTheRoot
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var paths = new Dictionary<string,Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                var path = Console.ReadLine()
                    .Split('\\')
                    .Select(t => t.Trim())
                    .ToArray();

                var root = path[0].Trim();
                var fileInfo = path[path.Length - 1].Split(';');
                var fileName = fileInfo[0];
                var fileSize = long.Parse(fileInfo.Last());

                if (!paths.ContainsKey(root))
                {
                    paths[root] = new Dictionary<string, long>();
                }

                paths[root][fileName] = fileSize;
            }

            var outputInfo = Console.ReadLine()
                .Split();

            var extention = "." + outputInfo[0];
            var fromRoot = outputInfo[outputInfo.Length - 1];

            var files = new Dictionary<string, long>();

            foreach (var path in paths)
            {
                foreach (var file in path.Value)
                {
                    if (path.Key == fromRoot && file.Key.EndsWith(extention))
                    {
                        files[file.Key] = file.Value;
                    }
                }
            }

            if (files.Any())
            {
                foreach (var file in files.OrderByDescending(f => f.Value).ThenBy(f => f.Key))
                {
                    Console.WriteLine($"{file.Key} - {file.Value} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
