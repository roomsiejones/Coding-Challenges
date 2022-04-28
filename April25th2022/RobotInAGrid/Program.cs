using RobotInAGrid;

int[,] checkIfWorks1 = new int[5, 5]{
    {0, 0, 1, 0, 0},
    {1, 0, 0, 0, 1},
    {0, 0, 1, 0, 0},
    {0, 0, 1, 1, 0},
    {1, 0, 0, 0, 0}
};

try
{
    for (int i = 0; i < checkIfWorks1.GetLength(0); i++)
    {
        for (int j = 0; j < checkIfWorks1.GetLength(1); j++)
        {
            Console.Write("{0} ", checkIfWorks1[i, j]);
        }
        Console.WriteLine();
    }

    Solution sol1 = new Solution();
    List<RobotPosition> result1 = sol1.CreatePath(checkIfWorks1);

    Console.Write("The found path is: ");
    foreach (var item in result1)
    {
        Console.Write(item + " ");
    }
}
catch (System.Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("\n------------------------\n------------------------\n------------------------");

int[,] checkIfWorks2 = new int[10, 10]{
    {0, 0, 1, 0, 0, 0, 1, 0, 1, 1},
    {0, 0, 1, 0, 0, 0, 1, 0, 1, 1},
    {0, 0, 0, 0, 0, 0, 1, 0, 1, 1},
    {0, 0, 1, 0, 0, 0, 1, 0, 1, 1},
    {0, 0, 1, 0, 0, 0, 0, 0, 1, 1},
    {0, 0, 1, 0, 0, 0, 1, 0, 1, 1},
    {0, 0, 1, 0, 0, 0, 1, 0, 1, 1},
    {0, 0, 1, 0, 0, 0, 1, 0, 0, 0},
    {0, 0, 1, 0, 0, 0, 1, 0, 1, 0},
    {0, 0, 1, 0, 0, 0, 1, 0, 1, 0},



};

try
{
    for (int i = 0; i < checkIfWorks2.GetLength(0); i++)
    {
        for (int j = 0; j < checkIfWorks2.GetLength(1); j++)
        {
            Console.Write("{0} ", checkIfWorks2[i, j]);
        }
        Console.WriteLine();
    }

    Solution sol2 = new Solution();
    List<RobotPosition> result2 = sol2.CreatePath(checkIfWorks2);

    Console.Write("The found path is: ");
    foreach (var item in result2)
    {
        Console.Write(item + " ");
    }
}
catch (System.Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("\n------------------------\n------------------------\n------------------------");

int[,] checkIfWorks3 = new int[5, 5]{
    {0, 0, 1, 0, 0},
    {1, 1, 1, 0, 1},
    {0, 0, 1, 0, 0},
    {0, 0, 1, 1, 0},
    {1, 0, 0, 0, 0}
};

try
{
    for (int i = 0; i < checkIfWorks3.GetLength(0); i++)
    {
        for (int j = 0; j < checkIfWorks3.GetLength(1); j++)
        {
            Console.Write("{0} ", checkIfWorks3[i, j]);
        }
        Console.WriteLine();
    }

    Solution sol3 = new Solution();
    List<RobotPosition> result3 = sol3.CreatePath(checkIfWorks3);

    Console.Write("The found path is: ");
    foreach (var item in result3)
    {
        Console.Write(item + " ");
    }
}
catch (System.Exception e)
{
    Console.WriteLine(e.Message);
}
