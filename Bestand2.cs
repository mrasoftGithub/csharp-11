namespace csharp11Solution
{
    public class Berekening_Exoot
    {
        public int Optellen(int x, int y)
        {
            RekenRegels rekenregels = new RekenRegels();
            return RekenRegels.DoeOptellen(x, y);
        }

        public int Verminderen(int x, int y)
        {
            RekenRegels rekenregels = new RekenRegels();
            return RekenRegels.DoeVerminderen(x, y);
        }
    }

    file class RekenRegels
    {
        public static int DoeOptellen(int a, int b) 
            => a + b + 1000;

        public static int DoeVerminderen(int a, int b)
        {
            if ( a - b < 0) return 0; else return a - b;
        }
    }
}
