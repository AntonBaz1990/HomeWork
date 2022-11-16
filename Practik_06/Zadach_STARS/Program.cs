// Задача со звездочкой: Напишите программу, которая реализует обход введенного двумерного массива, начиная с крайнего нижнего левого элемента против часовой стрелки.
// 1 2 3
// 4 5 6 -> 7 8 9 6 3 2 1 4 5
// 7 8 9

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]}");
//         }
//         Console.WriteLine();
//     }
// }

// void FilltArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// Console.Clear();


// int sizeI = int.Parse(Console.ReadLine()!);
// int sizeJ = int.Parse(Console.ReadLine()!);
// int[,] matrix = new int[sizeI, sizeJ];

// FilltArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// void PrintMass(int[,] matr)
// {
//     for (int i = matr.GetLength(0) - 1; i < matr.GetLength(0); i++)///левый  низ-> правый низ
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]}");
//         }
//         Console.WriteLine();
//     }



//     for (int i = matr.GetLength(0) - 1; i < matr.GetLength(0); i++) ///правый низ-> правый вверх
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]}");
//         }
//         Console.WriteLine();
//     }

//     for (int i = matr.GetLength(0) - 1; i < matr.GetLength(0); i++) ///правый низ-> правый вверх
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]}");
//         }
//         Console.WriteLine();
//     }

//      for (int i = matr.GetLength(0) - 1; i < matr.GetLength(0); i++) ///правый низ-> правый вверх
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]}");
//         }
//         Console.WriteLine();
//     }


// }


// PrintMass(matrix);
