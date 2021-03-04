using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    //intial array to hold the 10 initial numbers
    int[] arrayMain = new int [10]; 

    //2 seperate arrays for holding odd/even
    int[] OddNum = new int [10];
    int[] EvenNum = new int [10];
    int i, j= 0, k = 0;

    //getting 10 integers
    for (int i = 0; i < 10; i++)
    {
      Console.WriteLine ("Enter 10 integers");

      arrayMain[i] = Convert.ToInt32(Console.ReadLine());
    }

    //loop that sorts even and odd using remainder
    for (int i = 0; i < 10; i++)
    {
        if (arrayMain[i] % 2 == 0)
        {
          EvenNum[j] = arrayMain[i];
          j++;
        }

        else
        {
          OddNum[k] = arrayMain[i];
          k++;
        }
    }

    //odd numbers sorted descending
    Array.Sort(OddNum);
    Array.Reverse(OddNum);
    Console.WriteLine("Odd numbers sorted high to low:");
    for (i = 0; i < k; i++)
    {
      Console.WriteLine(OddNum[i]);
    }

    //even numbers sorted ascending
    Array.Sort(EvenNum);
    Console.WriteLine("Even numbers sorted low to high:");
    for (i = 0; i < j; i++)
    {
      Console.WriteLine(EvenNum[i]);
    }

  }
}