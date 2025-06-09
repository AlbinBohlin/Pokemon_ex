namespace Ovning_3
{
    public interface IEvolvable
    {
        string NewName { get; }
        void Evolve();
    }
}