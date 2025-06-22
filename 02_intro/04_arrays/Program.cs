
#region Одномерные массивы

//int[] a;

//int[] b = new int[2];

//int[] c = new int[4] { 3, 5, 7, 9 };

//int[] d = new int[] { 3, 5, 7, 9 };

//int[] e = new [] { 3, 5, 7, 9 };

//int[] f = { 3, 5, 7, 9 };

// Console.WriteLine(f[2]);
// Console.WriteLine(f[10]);        // ERROR

// f[2] = 100;

//Console.WriteLine(f.Length);

//Console.WriteLine(f[f.Length - 1]);
//Console.WriteLine(f[^1]);

//for (int i = 0; i < f.Length; i++)
//    Console.WriteLine(f[i]);

//foreach (int item in f)
//{
//    Console.WriteLine(item);
//}

#endregion

#region Многомерные массивы

//int[,] a;

//int[,] b = new int[2, 3];

//int[,] c = new int[2, 3] { { 3, 4, 5 }, { 7, 8, 9 } };

//int[,] d = new int[,] { { 3, 4, 5 }, { 7, 8, 9 } };

//int[,] e = new [,] { { 3, 4, 5 }, { 7, 8, 9 } };

//int[,] f = { { 3, 4, 5 }, { 7, 8, 9 } };

//int[,,] g =
//{
//    {
//        { 3, 4 },
//        { 5, 6 }
//    },
//    {
//        { 3, 4 },
//        { 5, 6 }
//    },
//    {
//        { 3, 4 },
//        { 5, 6 }
//    }
//};


//int[,] f = { { 3, 4, 5 }, { 7, 8, 9 } };

//Console.WriteLine(f.Length);

//Console.WriteLine(f.GetUpperBound(0));

//int rows = f.GetUpperBound(0) + 1;
//int cols = f.GetUpperBound(1) + 1;

//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < cols; j++)
//    {
//        Console.Write($"{f[i, j]}\t");
//    }
//    Console.WriteLine();
//}

#endregion

#region Зубчатые массивы

//int[][] arr = new int[3][];
//arr[0] = new int[4];
//arr[1] = new int[2];
//arr[2] = new int[3];


//int[][] arr =
//{
//    new int[4] { 1, 2, 3, 4 },
//    new int[2] { 5, 8 },
//    new int[3] { 1, 8, 9 },
//};


//int[][] arr =
//{
//    [1, 2, 3, 4],
//    [5, 8],
//    [1, 8, 9],
//};


#endregion
