namespace _11_Files
{
    internal class Stock
    {
        private string v1;
        private double v2;
        private int v3;

        public Stock(string v1, double v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public int Id { get; internal set; }
    }
}