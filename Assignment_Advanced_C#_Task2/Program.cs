using Assignment_Advanced_C__Task2;

internal class Program
{
    private static void Main(string[] args)
    {

        #region Question 01
        /*
         2-You are given an ArrayList containing a sequence of elements.
           try to reverse the order of elements in the ArrayList in-place(in the same arrayList)
           without using the built-in Reverse.
           Implement a function that takes the ArrayList as input 
           and modifies it to have the reversed order of elements.
         */

        // ArrayList array = Helper.SetArray();
        // Console.WriteLine("\n\nOriginal array elements:");
        // Helper.PrintArrayList(array);
        // 
        // Helper.ReverseArrayList(array);
        // Console.WriteLine("\n\nReversed array elements:");
        // Helper.PrintArrayList(array);
        #endregion

        #region Question 02
        /*
         3.You are given a list of integers.
           Your task is to find and return a new list containing only the even numbers from the given list.
         */

        //Assume this list as Given.
        // List<int> list = new List<int> { 10 , 12 , 14 , 17 , 19 , 20 }; 
        // 
        // List<int> evenList = new List<int>(); 
        // 
        // int count = list.Count; 
        // for (int i = 0; i < count; i++)
        // {
        //     if(list[i] % 2 == 0)
        //     {
        //         evenList.Add(list[i]);
        //     }
        // }
        // Console.WriteLine($"The even numbers from the given list:");
        // foreach (int item in evenList)
        // {
        //     Console.Write($"{item} ");
        // }
        #endregion

        #region Question 03
        //var fixedlist = new FixedSizeList<int>(3);

        //fixedlist.Add(1);
        //fixedlist.Add(2);
        //fixedlist.Add(3);

        //fixedlist.Add(4); 

        //Console.WriteLine(fixedlist.Get(1)); 
        //Console.WriteLine(fixedlist.Get(3));
        #endregion

        #region Question 04
        //string input = "SASS";
        //int index = FirstNonRepeatedCharacter.GetFirstNonRepeatedCharacterIndex(input);
        //if (index != -1)
        //{
        //    Console.WriteLine($"The first non-repeated character is at index {index}.");
        //}
        //else
        //{
        //    Console.WriteLine("No non-repeated character found.");
        //}
        #endregion
    }
}