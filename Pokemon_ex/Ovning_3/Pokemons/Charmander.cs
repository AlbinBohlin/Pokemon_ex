namespace Ovning_3.Pokemons
{
    using Ovning_3;
    using Ovning_3.Pokemons.Abstract;
    using Utils;
    internal class Charmander(List<Attack> attacks) : FirePokemon(attacks), IEvolvable
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
            
            

        } 
        
    }
}