using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindAndReplace;

namespace FindAndReplace.Tests
{
  [TestClass]
  public class ReplacerTests
  {
    [TestMethod]
    public void RemoveBlankSpaces_RemoveBlankSpaces_Hello_world()
    {
      Assert.AreEqual("Hello world", Replacer.RemoveBlankSpaces("Hello world"));
    }

    [TestMethod]
    public void FindAndReplace_ReplaceWordInText_ChangedText()
    {
      Assert.AreEqual("Hello universe", Replacer.FindAndReplace("Hello world", "world", "universe"));
    }

    [TestMethod]
    public void FindAndReplace_ReplaceWordPieceInText_ChangedText()
    {
      Assert.AreEqual("I am walking my dog to the doghedral", Replacer.FindAndReplace("I am walking my cat to the cathedral", "cat", "dog"));
    }
  }
}