namespace Ovning_3
{using Utils;
    internal class Charmander(List<Attack> attacks) : FirePokemon(attacks), IEvolvable
    {
        public void Evolve()
        {
            string new_name = "Charmeleon";
            base.Level += 10;
            base.Evolve(new_name);
        }
    }
}