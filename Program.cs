using DSA;


// THIS FUNCTION FINDS "NEMO" AND PRINT IT (FindAStringInAnArray class)

/*FindAStringInAnArray findAStringInAnArray = new FindAStringInAnArray();
string[] nemo = { "nemo", "Boj", "mi", "You" };
findAStringInAnArray.FindNemo(nemo);*/

//THIS FUNCTION COMPARES ITEM IN TWO DIFFERENT ARRAY (CompareCommonItems class)
CompareCommonItems compareCommonItems = new CompareCommonItems();
string[] array1 = { "a", "b", "c", "x" };
string[] array2 = {"z", "y", "x"};
bool result = compareCommonItems.ContainsCommonItem2(array1, array2);
Console.WriteLine(result);
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


/*//Fill up the empty array with Hi 
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
/*int[] result = arrayOfOdd(11);
Console.WriteLine(string.Join(", ", result));

static int[] arrayOfOdd(int n)
{
    int[] odd = new int[n];
    for (int i = 1; i < n; i++)
    {

    odd[i] = i*3;
    }
    return odd;
}*/
