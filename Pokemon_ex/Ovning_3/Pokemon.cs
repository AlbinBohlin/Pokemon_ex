using Ovning_3.Utils;

namespace Ovning_3
{
    public abstract class Pokemon( List<Attack> attacks, ElementType elementType) : IEvolvable
    {
        public required string Name { get; set; } 
        public required int Level { get; set; }
        private readonly ElementType element = elementType;
        public List<Attack> Attacks = attacks;

        public abstract string Attack();
        //  A non-overridable instance method:

        public void RaiseLevel()
        {
            //This should increment the level and print:

            Console.WriteLine($"{Name} leveled up to {Level}!");
        }

        public void Evolve(string newName)
        {   
            Console.WriteLine($"{Name} is evolving... Now it's {newName}! Level {Level}");
            Name=newName;

        }
    }


}