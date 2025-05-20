using Sealed_Static_Extension.Helper;
using Sealed_Static_Extension.Models;

namespace Sealed_Static_Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("John Doe", "A123", 20);
            Console.WriteLine($"Student1: Fullname={student1.Fullname}, GroupNo={student1.GroupNo}, Age={student1.Age}");

            Student student2 = new Student("john doe", "B234", 22);
            Console.WriteLine($"Student2: Fullname={student2.Fullname}, GroupNo={student2.GroupNo}, Age={student2.Age}");

            Student student3 = new Student("Jane Smith", "123A", 21);
            Console.WriteLine($"Student3: Fullname={student3.Fullname}, GroupNo={student3.GroupNo}, Age={student3.Age}");

            Console.WriteLine();

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
        }
    }
}
