using lab2;

// creating new matrix
MatrixHandler newMatrix = new MatrixHandler(-50, 50);
newMatrix.ShowMatrix();

// trying to find elements with same row and column indexes
List<int> elements = newMatrix.SameRowColumnElement();
Console.Write("\n");
foreach (int element in elements) Console.Write($"{element}; ");

// sum all elements in a row that have at least one negative number
int sum = newMatrix.SumAtLeastNegative();
Console.Write($"\nSum: {sum}");
