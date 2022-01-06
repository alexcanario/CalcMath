namespace CalcMath
{
    public class Operations
    {
        public int Soma(int x, int y)
        {
            return x + y;
        }

        public int Div(int x, int y)
        {
            var result = 0;
            if (x > 0 && y > 0 && x > y)
                result = x / y;

            return result;
        }

        public int Sub(int x, int y)
        {
            var result = 0;
            if (x > y)
                result = x - y;

            return result;
        }
    }
}
