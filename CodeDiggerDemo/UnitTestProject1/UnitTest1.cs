using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    public static class Some
    {
        public static string Capitalise(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return string.Empty;
            var array = text.Trim().ToCharArray();
            // Handle the first letter in the string.
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
            // Scan through the letters, checking for spaces.
            // ... Uppercase the lowercase letters following spaces.
            for (var i = 1; i < array.Length; i++)
            {
                if (array[i - 1] != ' ') continue;
                if (char.IsLower(array[i]))
                {
                    array[i] = char.ToUpper(array[i]);
                }
            }
            return new string(array);
        }
    }


    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = "THIS IS MY TEXT RIGHT NOW";

            var result = s.Capitalise();

            Assert.AreEqual(result, "This Is My Text Right Now");
        }
    }
}
