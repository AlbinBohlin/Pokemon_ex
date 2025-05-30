/*namespace Ovning_3
{
    using System.Runtime.CompilerServices;
    using System.Timers;
    using Utils;

    enum Test { a,b,c}
    public class ElementPokemon<T> (ElementType element, string name, int level): Pokemon(element, name, level) where T : Enum 
    {   
              readonly Ovning_3.Utils.ElementType Element = element;    
        public override string Attack()
        {
            throw new NotImplementedException();
        }


    }

    public class FFirePokemon<Fire> : ElementPokemon<ElementType>
    {   
        public FFirePokemon(string name, int level) : base(ElementType.Fire,name,level)
        {


        }
    }


}*/