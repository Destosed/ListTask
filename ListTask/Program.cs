using System;
using System.IO;

namespace ListTasks
{
    class Program
    {
        //Вариант 2
        static void Main(string[] args)
        {
            TestOut();
        }

        static void TestWordSet()
        {
            var lst = new WordSet(new string[] { "c", "b", "a", "d" });
            Console.WriteLine(lst.ToString());
        }

        static void TestTwoWordSets()
        {
            var lst1 = new WordSet(new string[] { "a", "r", "s" });
            var lst2 = new WordSet(new string[] { "z", "b", "o" });
            var lst = new WordSet(lst1, lst2);
            Console.WriteLine(lst);
        }

        static void TestOut()
        {
            var lst = new WordSet(new string[] { "c", "b", "a", "d" });
            lst.Out("output.txt");
        }

        static void TestInsert()
        {
            var lst = new WordSet(new string[] { "c", "a", "d" });
            lst.Insert("b");
            Console.WriteLine(lst.ToString());
        }

        static void TestDelete()
        {
            var lst = new WordSet(new string[] { "c", "a", "d", "b" });
            lst.Delete("c");
            Console.WriteLine(lst.ToString());
        }

        static void TestNewWordSetByWordLength()
        {
            var lst = new WordSet(new string[] { "a", "aa", "aaa", "bb", "bbbb", "cc" });
            lst = lst.NewWordSetByWordLength(2);
            Console.WriteLine(lst.ToString());
        }

        static void TestVowelDivide()
        {
            var lst = new WordSet(new string[] { "а", "б", "в", "г", "д", "е" });
            var arr = lst.VowelDivide();
            Console.WriteLine("{0} | {1}", arr[0], arr[1]);
        }

        static void TestRemovePalindrome()
        {
            var lst = new WordSet(new string[] { "ab", "abb", "bab", "aba", "abc", "abababa" });
            lst.RemovePalindrome();
            Console.WriteLine(lst.ToString());
        }
    }
}