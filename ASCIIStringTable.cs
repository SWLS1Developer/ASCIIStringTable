class ASCIIStringTable
    {
        public int Rows { get; private set; }
        public int Columns { get; private set; }
        private List<List<string>> data;

        public ASCIIStringTable(int rows, int columns)
        {
            this.Rows = rows;
            this.Columns = columns;
            data = new List<List<string>>();

            for (int i = 0; i < rows; i++)
            {
                data.Add(new List<string>());
                for (int j = 0; j < columns; j++)
                {
                    data[i].Add("");
                }
            }
        }

        public void AddData(int row, int column, string value)
        {
            data[row][column] = value;
        }

        public void DrawTable()
        {
            int[] columnWidths = new int[Columns];

            for (int i = 0; i < Columns; i++)
            {
                int maxLength = 0;
                for (int j = 0; j < Rows; j++)
                {
                    if (data[j][i].Length > maxLength)
                    {
                        maxLength = data[j][i].Length;
                    }
                    columnWidths[i] = maxLength;
                }
            }

            string horizontalSeparator = "+";
            for (int i = 0; i < Columns; i++)
            {
                horizontalSeparator += new string('-', columnWidths[i] + 2) + "+";
            }

            Console.WriteLine(horizontalSeparator);

            for (int i = 0; i < Rows; i++)
            {
                Console.Write("|");
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write(" " + data[i][j].PadRight(columnWidths[j]) + " |");
                }
                Console.WriteLine();
                Console.WriteLine(horizontalSeparator);
            }
        }
    }
