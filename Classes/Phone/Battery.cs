namespace Phone
{
    public class Battery
    {
        private readonly string model;
        private readonly BatteryType batteryType;
        private int IdleTime { get; set; }
        private int TalkTime { get; set; }

        public string Model
        {
            get
            {
                return this.model;
            }
        }

        public Battery(string model, BatteryType batteryType, int idle = 0, int talk = 0)
        {
            Validation.StringValidation(model);
            this.model = model;
            this.batteryType = batteryType;
            Validation.IsIntMoreThanZero(idle);
            this.IdleTime = idle;
            Validation.IsIntMoreThanZero(talk);
            this.TalkTime = talk;
        }

        public override string ToString()
        {
            return "Battery Model: " + this.model + "\nType: " + batteryType + "\nIdleTime: " + IdleTime + "\nTalkTime: " + TalkTime;
        }
    }
}