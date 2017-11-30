namespace Phone
{
    public class Battery
    {
        private readonly string model;
        private readonly BatteryType batteryType;
        private readonly int idleTime ;
        private readonly int talkTime;

        public Battery(string model, BatteryType batteryType, int idle = 0, int talk = 0)
        {
            Validation.StringValidation(model);
            this.model = model;
            this.batteryType = batteryType;
            Validation.IsIntMoreThanZero(idle);
            this.idleTime = idle;
            Validation.IsIntMoreThanZero(talk);
            this.talkTime = talk;
        }

        public string Model{get => this.model;}

        public override string ToString()
        {
            return $"Battery Model: {this.model}\nType: {this.batteryType}\nIdleTime: {this.idleTime}\nTalkTime: {this.alkTime}";
        }
    }
}