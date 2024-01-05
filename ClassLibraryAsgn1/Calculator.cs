namespace ClassLibraryAsgn1
{
    public class Calculator
    {
        public int fnum { get; set; }
        public int snum { get; set; }

        public int Mul()
        {
            int res;
            res = fnum * snum;
            return res;
        }

        public int Sub()
        {
            int res;
            res = fnum - snum;
            return res;
        }
        public int Div()
        {
            int res;
            res = fnum / snum;
            return res;
        }
    }
}