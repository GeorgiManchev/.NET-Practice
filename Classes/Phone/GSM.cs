using System;

namespace Phone
{
    public class GSM : IModelMadeBy
    {
        // const GSM IPhone4s = new GSM();

        private readonly string model;
        private readonly string manufacturer;
        public double Price { get; set; }
        public string Owner { get; set; }
        public Battery Battery { get; }
        public Display Display { get; }

        public GSM(string model, string manufacturer, double price, string owner, Battery battery, Display display)
        {
            Validation.StringValidation(model);
            this.model = model;
            Validation.StringValidation(manufacturer);
            this.manufacturer = manufacturer;
            Validation.IsIntLessThanZero(price);
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public string Model { get; }
        public string Manufacturer { get; }

        public void Print(ILogger logger)
        {
            string message = "Model:" + this.model + "\nMade by: " + this.manufacturer + "\nPrice: " + this.Price + "\nOwner: "
                + this.Owner + "\n*******\n" + this.Battery + "\n*******\n" + this.Display;
            logger.Log(message);
        }
    }
}