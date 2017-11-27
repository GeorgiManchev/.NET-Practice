namespace Phone
{
    public class Display
    {
        private readonly double size;
        private readonly uint colorsRange;

        public Display(double sizeInch, uint colorsRange)
        {
            Validation.IsIntMoreThanZero(sizeInch);
            this.size = sizeInch;
            Validation.IsIntMoreThanZero(colorsRange);
            this.colorsRange = colorsRange;
        }

        public double Size { get; }

        public uint ColorRange { get; }

        public override string ToString()
        {
            return "Size In Inches: " + size + "\nColorRange:" + colorsRange + "Milions";
        }
    }
}