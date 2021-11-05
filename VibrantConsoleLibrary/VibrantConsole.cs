using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("VibrantConsoleLibrary.Tests")]
namespace VibrantConsoleLibrary
{
    
    public static class VibrantConsole
    {
        public static void WriteLine(string text)
        {
            Console.WriteLine(text);
        }        
    }
}