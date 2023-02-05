# Class: ASCIIStringTable

A class that represents a table data structure, with rows and columns. 

## Properties
- `Rows` (int): A read-only property that returns the number of rows of the table.
- `Columns` (int): A read-only property that returns the number of columns of the table.

## Constructor
- `Table(int rows, int columns)`: A constructor that takes the number of rows and columns as parameters and creates a table with the specified dimensions.

## Methods
- `AddData(int row, int column, string value)`: Adds the value to the specified row and column in the table.
- `DrawTable()`: Draws the table to the console by formatting thedata in a tabular form with columns separated by separators and rows separated by horizontal separators. The width of each column is determined by the maximum length of data in that column. The table is drawn by writing to the console.
- 
## Example

```less
var table = new Table(3, 2);
table.AddData(0, 0, "Name");
table.AddData(0, 1, "Age");
table.AddData(1, 0, "John");
table.AddData(1, 1, "30");
table.AddData(2, 0, "Jane");
table.AddData(2, 1, "25");
table.DrawTable();
```

 Output
```g
+----+----+
| Name | Age |
+----+----+
| John | 30  |
+----+----+
| Jane | 25  |
+----+----+
```
