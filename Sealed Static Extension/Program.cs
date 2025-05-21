using Sealed_Static_Extension.Helper;
using Sealed_Static_Extension.Models;

namespace Sealed_Static_Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testString = "Hello123";
            Console.WriteLine($"\"{testString}\" contains digit? {testString.IsContainDigit()}");

            string name = "mahIr";
            Console.WriteLine($"Capitalize \"{name}\": {name.ToCapitalize()}");

            string sentence = "This is the first sentence. This is the second.";
            Console.WriteLine($"First sentence: {sentence.GetFirstSentence()}");

            string phrase = "Open AI ChatGPT";
            Console.WriteLine($"Second word in phrase: {phrase.GetSecondWord()}");

            string sample = "banana";
            char ch = 'a';
            int[] indexes = sample.GetValueIndexes(ch);
            Console.WriteLine($"Indexes of '{ch}' in \"{sample}\": {string.Join(", ", indexes)}");

            int number1 = 121;
            Console.WriteLine($"{number1} is palindrome? {number1.IsPalindrome()}");

            int number2 = 42;
            Console.WriteLine($"{number2} is even? {number2.IsEven()}, is odd? {number2.IsOdd()}");

            string text = "Hello hello HELLO world";
            string wordToCount = "hello";
            Console.WriteLine($"'{wordToCount}' repeated {text.ReplayedWordsCount(wordToCount)} times in \"{text}\"");

            ProgrammingStudent programmingStudent1 = new("John Doe", "A123", 20);
            Console.WriteLine($"Student1: Fullname={programmingStudent1.Fullname}, GroupNo={programmingStudent1.GroupNo}, Age={programmingStudent1.Age}");

            DesignStudent designStudent1 = new("john doe", "B234", 22);
            Console.WriteLine($"Student2: Fullname={designStudent1.Fullname}, GroupNo={designStudent1.GroupNo}, Age={designStudent1.Age}");

            DesignStudent designStudent2 = new("Jane Smith", "123A", 21);
            Console.WriteLine($"Student3: Fullname={designStudent2.Fullname}, GroupNo={designStudent2.GroupNo}, Age={designStudent2.Age}");

            programmingStudent1.DoHomeWork();
            designStudent1.DoHomeWork();
        }
    }
}
