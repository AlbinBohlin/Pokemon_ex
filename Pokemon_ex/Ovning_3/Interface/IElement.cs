using Ovning_3.Utils;

namespace Ovning_3.Interfaces
{
    /*
     * This Interface defines all methods and properties pertaining to Elemental stuff.
     * 
     * Some Pokemons, once evolved posess more than one element. 
     * 
     */
    public interface IElements
    {    
        
         public List<ElementType> GetTypes {  get; }
         

    }
}