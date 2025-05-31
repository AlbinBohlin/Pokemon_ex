namespace Ovning_3.Pokemons
{
    using Ovning_3.Pokemons.Abstract;

    public class Charmander(string name, int level, List<Attack> attacks) : FirePokemon(name, level, attacks)
    {
        //private readonly string[] _evolveTier = ["Charmeleon", "Charizard"];
        public void Evolve()
        {
            string new_name = "Charmeleon";
            Level += 10;
            Evolve(new_name);
            //this = new Charmeleon(this);
        }
        private class Charmeleon(Charmander c) {
            
            Charmander _c  = c;

        } 
        
    }
}