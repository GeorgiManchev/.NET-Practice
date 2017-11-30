namespace Phone
{
    class Program
    {
        static void Main()
        {
            var battery = new Battery("NONExplodingModel", BatteryType.NiCd, 200, 80);
            var display = new Display(5.2D, 200000);
            var nokiaC230 = new GSM("Very old model", "Nokia+FLashLight", 20, "Probably Dealer", battery, display);

            nokiaC230.Print(ConsoleLogger.GetInstance());
        }
    }
}
