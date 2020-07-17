using System;

namespace FindAndReplace
{
  public class Replacer
  {
    public static string FindAndReplace(string text, string word, string replacer)
    {
      string modifyText = RemoveBlankSpaces(text);
      string[] splitText = modifyText.Split(' ');
      for(int i = 0; i < splitText.Length; i++)
      {
        if(splitText[i].Contains(word))
        {
          splitText[i] = splitText[i].Replace(word, replacer);
        }
      }
      return String.Join(' ', splitText);
    }
    public static string RemoveBlankSpaces(string text)
    {
      string trimText = text.Trim();
      while(trimText.Contains("  "))
      {
        trimText.Replace("  ", " ");
      }
      return trimText;
    }
  }
}