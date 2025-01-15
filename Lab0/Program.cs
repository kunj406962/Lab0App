/*
 * CPRG 211 Lab 0 Activity
 * Author: Kunj
 * When: Winter 2025
 */

// get low and high int numbers
// low must be positive
// high must be greater than low

using Lab0;

int low, high;
int diff;   // difference between low and high
string[] readText;
int total=0;
int num;
bool primenum;

low = Utilities.GetPositiveInt("low number");

high = Utilities.GetIntInRange("high number", low + 1, Int32.MaxValue); // the largest int possible


// calculate and  print the difference
diff = high - low;
Console.WriteLine($"The difference between {low} and {high} is {diff}");

// create an array to hold numbers between low and high
List<int> numbers = new List<int>(); // size of the array
for(int i = 0; i <= diff; i++) // i is the index
{
    numbers.Add(low + i);
}

Console.WriteLine("Numbers in the array:");
for (int i = 0; i <= diff; i++)
{
    Console.WriteLine(numbers[i]);
}

// create a file named "number.txt" and write to it the numbers from the array in reverse order
StreamWriter streamWriter = File.CreateText("numbers.txt"); // located in the same folder as the .exe file
for(int i = numbers.Count - 1; i >= 0; i--)
{
    streamWriter.WriteLine(numbers[i]);
}
streamWriter.Close();// important to finalize the writing
Console.WriteLine("File written");

// read "number.txt", get the numbers aand add them
readText = File.ReadAllLines("numbers.txt"); // opening the fie
for (int i = 0; i < readText.Length; i++)
{
    num= Convert.ToInt32(readText[i]); //converting the lines in string format to integers
    total += num;
}
Console.WriteLine($"\nThe total of the numbers is {total}");

//print prime numbers
Console.WriteLine($"\nThe Prime numbers between {low} and {high} are:");
for (int i = 0; i < numbers.Count; i++)
{
    primenum = Utilities.PrimeNumber(numbers[i]);
    if (primenum)
    {
        Console.WriteLine(numbers[i]);
    }

}


