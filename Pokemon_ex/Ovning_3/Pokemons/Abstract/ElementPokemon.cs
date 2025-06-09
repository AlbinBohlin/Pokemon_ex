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
     
        public string ElementSpecificMethod()
        {
            return $"{""}Etg";
        }


    }


}