using FactoryMethod.Models;
using FactoryMethod.Factories.Interfaces;

namespace FactoryMethod.Factories.QuestionFactory
{

    public sealed class FatherQuestionFactory : IFactory<Question>
    {
        private const string FATHER_QUESTION = "What is your father\'s full name?";

        public Question Create()
        {
            return new Question(FATHER_QUESTION, GetAnswer());
        }

        private string GetAnswer()
        {
            return "J***** A**** A***** L*****";
        }
    }
}

