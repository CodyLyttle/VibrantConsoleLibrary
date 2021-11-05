using System;
using System.IO;
using Xunit;
// ReSharper disable Xunit.XunitTestWithConsoleOutput

namespace VibrantConsoleLibrary.Tests
{
    public class VibrantConsoleTests
    {
        [Fact]
        public void WriteLine_OnString_WritesStringToConsole()
        {
            StringWriter writer = new();
            Console.SetOut(writer);
            const string input = "Test";
            VibrantConsole.WriteLine(input);
            Console.SetOut(Console.Out);

            const string expected = input + "\r\n";
            string actual = writer.ToString();
            
            Assert.Equal(expected, actual);
        }
    }
}