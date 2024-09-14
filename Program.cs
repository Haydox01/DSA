using DSA;
using DSA.Core_Concepts;
using DSA.Questions_and_Solutios;


// THIS FUNCTION FINDS "NEMO" AND PRINT IT (FindAStringInAnArray class)

/*FindAStringInAnArray findAStringInAnArray = new FindAStringInAnArray();
string[] nemo = { "nemo", "Boj", "mi", "You" };
findAStringInAnArray.FindNemo(nemo);*/

//THIS FUNCTION COMPARES ITEM IN TWO DIFFERENT ARRAY (CompareCommonItems class)

/*CompareCommonItems compareCommonItems = new CompareCommonItems();
string[] array1 = { "a", "b", "c", "x" };
string[] array2 = {"z", "y", "x"};
bool result = compareCommonItems.ContainsCommonItem2(array1, array2);
Console.WriteLine(result);*/

//LOG ALL PAIRS OF ARRAY (PrintAllPairOfAnArray class)

/*PrintAllPairOfAnArray printAllPairOfAnArray = new PrintAllPairOfAnArray();
string[] boxes = { "a", "b", "c", "d", "e" };
printAllPairOfAnArray.logAllPairsOfArray(boxes);*/



//LOG FIRST TWO BOXES

/*LogFirstTwoItem logFirstTwoItem = new LogFirstTwoItem();
int[] boxes = new int[] { 1, 2, 3, 4, 5 };
logFirstTwoItem.logFirstTwoBoxes(boxes);*/

//FIBONACCI

/*Fibbonacci fibbonacci = new Fibbonacci();
int[] result =fibbonacci.FibonacciMethod(7);
Console.WriteLine(string.Join(", ", result));
*/

// Print Boo five times 
/*PrintNTimes printNTimes = new PrintNTimes();
int[] n = { 1, 2, 3, 4, 5 };
printNTimes.Boo(n);*/

//Fill up the empty array with Hi 
/*FillUpEmptyArrayNTimes fillUpEmptyArrayNTimes = new FillUpEmptyArrayNTimes();
string[] result =fillUpEmptyArrayNTimes.arrayOfHiNTimes(4);
Console.WriteLine(string.Join(", ", result));*/

//Fill Up with even numbers
/*FillUpArrayWithEvenNumbers fillUpArrayWithEvenNumbers = new FillUpArrayWithEvenNumbers();
int[] result =fillUpArrayWithEvenNumbers.EvenArray(20);
Console.WriteLine(string.Join(", ", result));
*/

//Fill Up with Odd Numbers
/*FillUpArrayWithOddNumbers fillUpArrayWithOddNumbers = new FillUpArrayWithOddNumbers();
int[] result = fillUpArrayWithOddNumbers.OddArray(20);
Console.WriteLine(string.Join(", ", result));
*/

//SUM OF ELEMENTS IN AN ARRAY
/*SumOfElementsInAnArray sumOfElementsInAnArray = new SumOfElementsInAnArray();
int[] arr = { 1, 2, 3, 4, 5, 6, 7, };
int result = sumOfElementsInAnArray.SumOfArray(arr);
Console.WriteLine(string.Join(", ", result));*/

//TWO SUM

PrintTwoIndexEqualToSum p = new PrintTwoIndexEqualToSum();
int[] arr = { 2, 4, 5, 6, 10, 1 };
int[] found = p.TwoSum(arr, 78);
Console.WriteLine(string.Join(", " , found));

//PRINT THE LONGEST WORD IN A SENTENCE
/*FindTheLongestWordInASentence findTheLongestWord = new FindTheLongestWordInASentence();
string sentence = " All of these sentence ";
string result =findTheLongestWord.longestEvenWord(sentence);
Console.WriteLine(string.Join(", ", result));*/


// RECURSION

/*Recursion r = new Recursion();
 var sum = r.FactorialOfNUsingLoop(5);
Console.WriteLine(sum);*/

// SEARCHING ALGORITHM

/*SearchingAlgorithm s = new SearchingAlgorithm();
int[] A = { 10, 40, 46, 68, 89};
int found = s.BinarySearchRecursive(A, 89, 0, 4);
Console.WriteLine(found);*/

//SORTING ALGORITHM
/*Sorting s = new Sorting();
int[] A = { 3, 45, 2, 14, 27, 8 };
Console.WriteLine("Original Array");
s.Display(A, 6);
s.InsertionSort(A, 6);
Console.WriteLine("Sorted Array");
s.Display(A, 6);*/
