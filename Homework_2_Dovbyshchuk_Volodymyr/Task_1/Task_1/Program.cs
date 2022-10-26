using Task_1;

RectangularMatrix matrix = new RectangularMatrix();

Console.WriteLine(matrix);

RectangularMatrix matrix1 = new RectangularMatrix(3,4);

matrix1.VerticalSnake();
Console.WriteLine(matrix1);

matrix1[2, 2] = 100;
Console.WriteLine(matrix1);

RectangularMatrix matrix2 = new RectangularMatrix(4);

matrix2.Initialize();
Console.WriteLine(matrix2);

matrix2.DiagonalSnake();
Console.WriteLine(matrix2);

RectangularMatrix matrix3 = new RectangularMatrix(5,4);

Console.WriteLine(matrix3);

matrix3.SpiralSnake();
Console.WriteLine(matrix3);





