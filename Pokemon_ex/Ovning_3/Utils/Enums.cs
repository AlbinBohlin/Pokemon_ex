namespace Ovning_3.Utils
{
    public enum ElementType
    {
        Fire,
        Water,
        Electric,

    }
    public enum Fire
    {
        Flamethrower = 12,
            ember = 13,
    }
    public enum Electric { }
    public enum Water { }

    class BasePower()
    {
        public static int Get(Enum weapon)
        {
            var vals = Enum.GetValues<Fire>().Select(g => new KeyValuePair<string, int>(g.ToString(), (int)g));
            Dictionary<string, int> dic = vals.ToDictionary();
            int val;
            dic.TryGetValue(weapon.ToString(), out val);
            return val;
        }
    }
}