namespace Ovning_3.Pokemons.Abstract
{   /*
     * Base class for all Pokemons
     * 
     */
    public abstract class Pokemon(string name, int level, List<Attack> attacks, ElementType elementType) 
    {
        public string Name { get; set; } = name;
        public int Level { get; set; } = level;
        private readonly ElementType element = elementType;
        public List<Attack> Attacks = attacks;

        public virtual void Attack()
        {/*
            ***Basic version * *: Return the result of calling `.Use(Level)` on a default attack from the list.
            ***Advanced version * *: Present a numbered menu listing the available attacks. The user selects one(e.g., via `Console.ReadLine()`), and the method then returns the result of calling `.Use(Level)` on the chosen attack.
       */
            foreach (Attack attack in Attacks)
            {
                if (this.element == attack.Type)//if the pokemon element matches the attack element
                {
                    Console.WriteLine(attack.Use(Level));
                }
            }
        }
        //  A non-overridable instance method:
        public void RaiseLevel(int lvl = 1)
        {
            Level += lvl;
            //This should increment the level and print:

            Console.WriteLine($"{Name} leveled up to {Level}!");
        }
/*
        public void Evolve(string newName)
        {
            Console.WriteLine($"{Name} is evolving... Now it's {newName}! Level {Level}");
            Name = newName;

        }*/
    }


}