// THIS FUNCTION FINDS "NEMO" AND PRINT IT
/*string[] nemo = { "nemo", "Boj", "mi", "You" };
FindNemo(nemo);

static void FindNemo(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Running");
        if (array[i] == "nemo")
        {
            Console.WriteLine("found nemo");
            break;
        }

    }//0(n) linear: Using break; helps us break out of the loop once we found nemo,
     //else it wouldve looped through all the the elements even after finding nemo
}*/


/*
//LOG ALL PAIRS OF ARRAY
string[] boxes = {"a", "b", "c", "d", "e"};
logAllPairsOfArray(boxes);

static void logAllPairsOfArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            Console.WriteLine(array[i] + array[j]);
        }
    }
}*/


//LOG FIRST TWO BOXES

/*int[] boxes = new int[] { 1, 2, 3, 4, 5 };
logFirstTwoBoxes(boxes);

static void logFirstTwoBoxes(int[] boxes)
{
    Console.WriteLine(boxes[0]);
    Console.WriteLine(boxes[1]);
}//0(1). But 0(2) for two operations
*/

//FIBONACCI

/*int[] result = Fibonacci(7);
Console.WriteLine(string.Join(", ", result));

static int[] Fibonacci(int n)
{
    if (n < 1) return new int[0];
    if (n == 1) return new int[] { 0 };

    int[] fib = new int[n];
    fib[0] = 0;
    fib[1] = 1;
    for (int i = 2; i < n; i++)
    {
        fib[i] = fib[i - 1] + fib[i - 2];
    }
    return fib;
}
*/

// Print Boo five times 
/*int[] n = { 1, 2, 3, 4, 5 };
Boo(n);
static void Boo(int[] array)
{
    for (int i = 0; i <array.Length ; i++)
    {
        Console.WriteLine("boooo");
    }
}*/


/*//Fill up the the empty array 
string[] result = arrayOfHiNTimes(4);
Console.WriteLine(string.Join(", ", result));

static string[] arrayOfHiNTimes(int n)
{
   string[] hiArray = new string[n];
    for (int i = 0; i < n; i++)
    {
        hiArray[i] = "Hi";
    }
    return hiArray;
}
*/
