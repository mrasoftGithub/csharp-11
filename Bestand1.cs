namespace csharp11Solution
{
    public class Berekening_Correct
    {
        public int Optellen(int x, int y)
        {
            RekenRegels rekenregels = new RekenRegels();
            return RekenRegels.DoeOptellen(x, y);
        }

        public int Verminderen (int x, int y)
        {
            RekenRegels rekenregels = new RekenRegels();
            return RekenRegels.DoeVerminderen(x, y);
        }
    }

    public class RekenRegels
    {
        public static int DoeOptellen(int a, int b) 
            => a + b;

        public static int DoeVerminderen(int a, int b) => a - b;
    }
}
