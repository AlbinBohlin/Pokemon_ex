namespace Ovning_3
{
    
    using Utils;

    internal class Program
    {
        static void Main(string[] args)
        {
            var flamethrower = new Attack<Fire>(Fire.Flamethrower);
          /*  var ember = new Attack<Fire>("Ember", 6);
            var shock = new Attack<Electric>("shock",  8);
            var lightning = new Attack<Electric>("Lightning", 13);
            var wave = new Attack<Water>("Wave", 34);
            var vortex = new Attack<Water>("Vortex",6);*/
            var o=new List<Attack<Fire>>() { flamethrower,};

            Charmander f = new(o) { Name ="Charmander", Level = 2};
            Console.WriteLine(f.Name);
            f.Attack();
            Console.WriteLine();
        


        }
    }
}
