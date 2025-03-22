using FactoryMethod.Factories.QuestionFactory;
using FactoryMethod.Factories.Interfaces;
using FactoryMethod.Models;
using System.Text.Json;

namespace FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IFactory<Question> questionFactory = new MotherQuestionFactory();
            var question =  questionFactory.Create();
            Console.WriteLine($"Mother Question: {JsonSerializer.Serialize(question).Replace("\\u0027", "'")}");

            questionFactory = new FatherQuestionFactory();
            question = questionFactory.Create();
            Console.WriteLine($"Father Question: {JsonSerializer.Serialize(question).Replace("\\u0027", "'")}");

            question = QuestionFactory.Create("MOTHER");
            Console.WriteLine("Another way to create question...");
            Console.WriteLine($"Mother Question: {JsonSerializer.Serialize(question).Replace("\\u0027", "'")}");
        }
    }
}

