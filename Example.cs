static void Main(string[] args)
{
    int[] set1, set2;

    // Both set1 and set2 are assigned the value of an empty int array.
    set1 = set2 = Array.Empty<int>();

    // If set1 is empty, read input from the user and store in set1
    if (set1.Length == 0)
    {
        Console.Write("First Set > ");
        set1 = Console.ReadLine().Trim().Split(',')
               .Select(t => int.Parse(t)).ToArray<int>();
    }

    // If set2 is empty, read input from the user and store in set2
    if (set2.Length == 0)
    {
        Console.Write("Second Set > ");
        set2 = Console.ReadLine().Trim().Split(',')
               .Select(t => int.Parse(t)).ToArray<int>();
    }

    // Clear the console
    Console.Clear();

    // Create a table with 4 rows and 2 columns
    var Table = new ASCIIStringTable(4, 2);

    // Add headings to the table
    Table.AddData(0, 0, "First Set");
    Table.AddData(1, 0, "Second Set");
    Table.AddData(2, 0, "Intersection Set");
    Table.AddData(3, 0, "Union Set");

    // Add the set data to the table
    Table.AddData(0, 1, string.Join(", ", set1));
    Table.AddData(1, 1, string.Join(", ", set2));
    Table.AddData(2, 1, string.Join(", ", set1.Intersect(set2)));
    Table.AddData(3, 1, string.Join(", ", set1.Union(set2)));

    // Draw the table to the console
    Table.DrawTable();

    // Wait for the user to press a key
    Console.ReadKey();
}
