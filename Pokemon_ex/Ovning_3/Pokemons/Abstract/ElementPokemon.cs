using Ovning_3.Utils;

namespace Ovning_3.Pokemons.Abstract
{   /*
     * Base class for all Stuff relating to Elements
     * Implements the Ielement Interface
     * Fields are required for easier instantiations and less clutter
     */
    public abstract class ElementalPokemon(List<Attack> attacks, ElementType elementType) : IEvolvable
    {
        public required string Name { get; set; }
        public required int Level { get; set; }
        private readonly ElementType element = elementType;
        public required List<Attack> Attacks = attacks;

        public virtual string Attack()
        {

            throw new NotImplementedException();

        }
        //  A non-overridable instance method:
        public void RaiseLevel(int lvl = 1)
        {
            Level += lvl;
            //This should increment the level and print:

            Console.WriteLine($"{Name} leveled up to {Level}!");
        }

        public void Evolve(string newName)
        {
            Console.WriteLine($"{Name} is evolving... Now it's {newName}! Level {Level}");
            Name = newName;

        }
    }


}