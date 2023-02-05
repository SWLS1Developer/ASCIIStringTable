static void Main(string[] args)
        {
            int[] set1, set2;

            set1 = set2 = Array.Empty<int>();

            if (set1.Length == 0)
            {
                Console.Write("First Set > ");
                set1 = Console.ReadLine().Trim().Split(',').Select(t => int.Parse(t)).ToArray<int>();
            }

            if (set2.Length == 0)
            {
                Console.Write("Second Set > ");
                set2 = Console.ReadLine().Trim().Split(',').Select(t => int.Parse(t)).ToArray<int>();
            }

            Console.Clear();

            var Table = new ASCIIStringTable(4, 2);
            Table.AddData(0, 0, "First Set");
            Table.AddData(1, 0, "Second Set");
            Table.AddData(2, 0, "Intersection Set");
            Table.AddData(3, 0, "Union Set");

            Table.AddData(0, 1, string.Join(", ", set1));
            Table.AddData(1, 1, string.Join(", ", set2));
            Table.AddData(2, 1, string.Join(", ", set1.Intersect(set2)));
            Table.AddData(3, 1, string.Join(", ", set1.Union(set2)));

            Table.DrawTable();
            Console.ReadKey();
        }
