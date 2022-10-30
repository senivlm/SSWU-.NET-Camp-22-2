using Task_3;


Cube cube1 = new Cube();

Cube cube2 = new Cube(1, 2, 3);

Cube cube3 = new Cube(3);

cube3.Initialize();

Console.WriteLine(cube3);

Console.WriteLine(cube2.IsThroughHole());