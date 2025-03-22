
namespace FactoryMethod.Models
{
    public class Question
    {
        public string Description { get; }
        public string Answer { get; }

        public Question(string description, string answer)
        {
            Description = description;
            Answer = answer;
        }
    }
}



