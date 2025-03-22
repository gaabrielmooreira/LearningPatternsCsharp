using FactoryMethod.Factories.Interfaces;
using FactoryMethod.Models;

namespace FactoryMethod.Factories.QuestionFactory
{
    public class QuestionFactory
    {
        public static Question Create(string type)
        {
            switch (type)
            {
                case "MOTHER":
                    return new MotherQuestionFactory().Create();
                case "FATHER":
                    return new FatherQuestionFactory().Create();
                default:
                    throw new Exception("This type hasn't been implemented yet.");
            }
        }
    }
}
