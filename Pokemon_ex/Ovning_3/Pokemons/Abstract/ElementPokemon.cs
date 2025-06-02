using Ovning_3.Actions;
using Ovning_3.Utils;

namespace Ovning_3.Pokemons.Abstract
{   /*
     * Base class for all Stuff relating to Elements
     * Implements the Ielement Interface
     * Fields are required for easier instantiations and less clutter
     */
    public abstract class ElementalPokemon(ElementType elementType) : Pokemon( elementType)
    {
       
        private readonly ElementType element = elementType;
     

        
        //  A non-overridable instance method:
      

        public void Evolve(string newName)
        {
            Console.WriteLine($"{Name} is evolving... Now it's {newName}! Level {Level}");
            Name = newName;

        }
    }


}