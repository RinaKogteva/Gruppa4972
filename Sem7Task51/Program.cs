// // Пример 1

// // Вывод сообщения и запись введённых данных
// int Prompt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine()??",";
//     int number = Convert.ToInt32(value);

//     return number;
// }
// // Заполняет массив случайными цифрами
// void Random2DArray(int[,] array, int minElement, int maxElement)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(minElement, maxElement);
// }
// // Ищет элементы, у которых оба индекса чётные и меняет их
// int MainDiagonalSum(int[,] array)
// {
//     int sum = 0;

//     for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
//         sum += array[i, i];

//     return sum;
// }
// // Выводит элементы массива в консоль
// void Output2DArray(int[,] array, string message)
// {
//     Console.WriteLine(message);

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("{");

//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//             Console.Write(array[i, j] + ",\t ");

//         Console.WriteLine(array[i, array.GetLength(1) - 1] + "}");
//     }
// }

// int m = Prompt("Введите m: ");
// int n = Prompt("Введите n: ");
// int minElement = 0;
// int maxElement = 10;

// int[,] array = new int[m, n];
// Random2DArray(array, minElement, maxElement);
// Output2DArray(array, "Массив: ");

// Console.WriteLine("Сумма эл-тов главной диагонали: " + MainDiagonalSum(array));

// Пример 2

// int ReadData(string msg) // вводим данные
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }


// int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
// {
//     int[,] array2D = new int[countRow, countColumn];
//     for (int i = 0; i < countRow; i++)
//     {
//         for (int j = 0; j < countColumn; j++)
//         {
//             array2D[i, j] = new Random().Next(downBorder, topBorder + 1);
//         }
//     }
//     return array2D;
// }
// void Print2DArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.ForegroundColor = ConsoleColor.Red;
//             Console.Write(matrix[i,j]+" ");
//             Console.ResetColor();
//         }
//         Console.WriteLine();
//     }
// }

// int MainDiagSum(int[,] matrix)
// {
//     int n = matrix.GetLength(0) < matrix.GetLength(1)? matrix.GetLength(0): matrix.GetLength(1);
//     int sum = 0;
//     for (int i = 0; i < n; i++)
//     {
//         sum+=matrix[i,i];
//     }
//     return sum;
// }

// int row = ReadData("введите количество строк: ");
// int column = ReadData("Введите количество столбцов: ");
// int[,] arr2D = Fill2DArray(row,column,10,1);
// Print2DArray(arr2D);
// Console.WriteLine($"Сумма главной диаганали {MainDiagSum(arr2D)}");

//Пример 3

Task t = new Task51();
t.Run();

abstract class Task
{
public static int[,] Gen2DArray(int axis0, int axis1, int low = -2147483648, int high = 2147483647)
{
    int[,] array = new int[axis0,axis1];
    for(int i = 0 ; i < axis0; i++){
        for(int j = 0;  j < axis1; j++)
        {
            array[i,j] = new Random().Next(low,high);
        }
    }
    return array;
}

public static void Print2DArray<T>(T[,] array)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.Write("[");
    for(int i = 0; i < array.GetLength(0)-1; i++){
            Console.Write("[");
    for(int j = 0; j < array.GetLength(1)-1; j++)
    {
    {
        Console.Write($"{array[i,j ]}, ");
    }
    }
    Console.Write($"{array[i,array.GetLength(1)-1]}],");
    Console.WriteLine();
    }
    Console.Write("[");
    for(int j = 0; j < array.GetLength(1)-1; j++)
    
    {
    {
        Console.Write($"{array[array.GetLength(0)-1,j]}, ");
        
    }
    }
    Console.Write($"{array[array.GetLength(1)-1,array.GetLength(1)-1]}]");
    Console.WriteLine("]");
}

    public static int ReadData(){
        return int.Parse(Console.ReadLine()??"0");
    }

abstract public void Run();
}


class Task48: Task
{
    int m = Task.ReadData();
    int n = Task.ReadData();
    

    private int[,] FillArray(int m, int n)
    {
        int [,] array = new int[m,n];
        for(int i = 0; i < m; i++){
            for (int j = 0; j< n; j++)
            {
                array[i,j] = i+j;
            }
        }
        return array;
    }

    public override void Run()
    {
        Task.Print2DArray<int>(FillArray(m,n));
    }

}


class Task49: Task

{
    private int[,] array = Gen2DArray(ReadData(),ReadData(), -1000,1000);
    
    private void squareEvens(int[,] array)
    {
        for(int i = 0; i < array.GetLength(0); i+=2)
        {
            for (int j = 0; j < array.GetLength(1); j+=2)
            {
                array[i,j] = array[i,j]*array[i,j];
            }
        }
    }

    public override void Run()
    {
        Console.WriteLine("Enter m, n line by line: ");
        Task.Print2DArray<int>(array);
        squareEvens(array);
        Console.WriteLine();
        Task.Print2DArray<int>(array);
    }



}


class Task51: Task
{

    public Task51(){
        Console.WriteLine("Enter m, n line by line: ");
        int m = ReadData();
        int n = ReadData();
        minAxis = m < n? m: n;
        array = Gen2DArray(m,n,-2147483648/minAxis,2147483647/minAxis);
    }

    private int minAxis;
    private int m;

    private int n;
    private int[,] array;

    private int sum = 0;

    
    private void findSumMain()
    {
        for (int i = 0; i < minAxis; i++)
        sum+=array[i,i];
    }

    public override void Run()
    {
        Console.WriteLine("Init array: ");
        Task.Print2DArray<int>(array);
        findSumMain();
        Console.WriteLine();
        Console.WriteLine($"Sum: {sum}");
    }



}