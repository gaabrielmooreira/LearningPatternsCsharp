using FactoryMethod.Models;
using FactoryMethod.Factory.Interfaces;

namespace FactoryMethod.Factory
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

