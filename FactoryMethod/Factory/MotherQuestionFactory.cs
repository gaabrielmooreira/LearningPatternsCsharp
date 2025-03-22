using FactoryMethod.Models;
using FactoryMethod.Factory.Interfaces;

namespace FactoryMethod.Factory
{

    public sealed class MotherQuestionFactory : IFactory<Question>
    {
        private const string MOTHER_QUESTION = "What is your mother\'s full name?";

        public Question Create()
        {
            return new Question(MOTHER_QUESTION, GetAnswer());
        }

        private string GetAnswer()
        {
            return "R***** P**** M***** L*****";
        }
    }
}

