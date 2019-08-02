using System;
using System.Collections;

/*  
  HashTable use key value pair to store data in Object.
  In HashTable it's very easy to search any value as HashTable maintain key to identify specific value.
 */
namespace ConsoleApp55
{
  class Program
  {
    public static void Main()
    {
      Hashtable hashtable = new Hashtable();
      hashtable[1] = "One";
      hashtable[2] = "Two";
      hashtable[3] = "Three";
      foreach (DictionaryEntry t in hashtable)
      {
        Console.WriteLine(t.Key + "  " + t.Value);
      }
    }
  }
}
