using System;

namespace Phone
{
    public class GSM : IModelMadeBy
    {
        private readonly string model;
        private readonly string madeBy;
        private readonly Battery battery;
        private readonly Display display;
        private double price;
        private string owner;

        public GSM(string model, string madeBy, Battery battery, Display display, double price=0, string owner="none")
        {
            Validation.StringValidation(model);
            this.model = model;
            Validation.StringValidation(madeBy);
            this.madeBy = madeBy;
            this.Battery = battery;
            this.Display = display;

            this.Price = price;
            this.Owner = owner;
        }

        public double Price 
        { 
            get => this.price;

            set 
            {
                Validation.IsIntLessThanZero(value);
                this.price = value;
            }
        }
        public  string Owner { get => this.owner; set; }
        public string Model { get => this.model; }
        public string madeBy { get => this.madeBy; }

        public void Print(ILogger logger)
        {
            var msg = $"Model:{this.model}\nMade by: {this.madeBy}\nPrice: {this.price}\nOwner: {this.owner}
            \n*******\n{this.battery}\n*******\n{this.display}";
            logger.Log(msg);
        }
    }
}