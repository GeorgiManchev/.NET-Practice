namespace Phone
{
    public class Display
    {
        private readonly double size;
        private readonly int colors;

        public Display(double size, int colors)
        {
            Validation.IsIntMoreThanZero(size);
            this.size = size;
            Validation.IsIntMoreThanZero(colors);
            this.colors = colors;
        }

        public double Size { get => this.size; }

        public int Colors { get => this.colors; }

        public override string ToString()
        {
            return $"Size: {this.size} inches\nColors: {this.colors} milions";
        }
    }
}