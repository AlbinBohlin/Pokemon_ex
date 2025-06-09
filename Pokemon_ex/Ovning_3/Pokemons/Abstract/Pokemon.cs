
namespace Ovning_3.Pokemons.Abstract
{   /*
     * Base class for all Pokemons
     * 
     */
    using Ovning_3.Utils;
    public abstract class Pokemon(string name, int level, List<Attack> attacks, ElementType elementType)
    {
        public string Name { get; set; } = name;
        public int Level { get; set; } = level;
        private readonly ElementType element = elementType;
        public List<Attack> Attacks = attacks.Where(a => a.Type == elementType).ToList();//sort out wrongful attacks


        public virtual void RandomAttack()
        {
            Console.WriteLine(Attacks[Generate.RandomInt(Attacks.Count)].Use(Level));
        }

        public virtual void Attack()
        {
            int inp =1;
            Console.WriteLine("Select attack by number:");
            for (int i = 0; i < Attacks.Count; i++)
            {
                Console.WriteLine($"{i+1}: {Attacks[i].Name}");
            }
            do
            {
                if (inp<=0 || inp>Attacks.Count) Console.WriteLine("invalid input");
                //Returns 0 if failparse 
                int.TryParse(Console.ReadLine(), out inp);

            } while (!Enumerable.Range(1, Attacks.Count).Contains(inp));
            Console.WriteLine(Attacks[inp-1].Use(Level));
            }

        public void RaiseLevel(int lvl = 1)
        {
            Level += lvl;
            Console.WriteLine($"{Name} leveled up to {Level}!");
        }

        public void Evolve(string newName)
        {
            Level += 10;
            Console.WriteLine($"{Name} is evolving... Now it's {newName}! Level {Level}");
            Name = newName;
        }

    }


}