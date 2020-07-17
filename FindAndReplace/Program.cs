using System;
using FindAndReplace;
class Program
{
  static void Main()
  {
    Console.WriteLine("Input the text:");
    string text = Console.ReadLine();
    Console.WriteLine("Input the word or part the word needs to be replaced");
    string word = Console.ReadLine();
    Console.WriteLine("Input the replacer word");
    string replacer = Console.ReadLine();
    Console.WriteLine(Replacer.FindAndReplace(text, word, replacer));
  }
}