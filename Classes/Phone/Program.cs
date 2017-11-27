namespace Phone
{
    class Program
    {
        static void Main()
        {
            Battery battery = new Battery("NONExplodingModel", BatteryType.NiCd, 200, 80);
            Display display = new Display(5.2D, 200000);
            GSM nokiaC230 = new GSM("Very old model", "Nokia+FLashLight", 20, "Probably Dealer", battery, display);

            nokiaC230.Print(ConsoleLogger.GetInstance());
        }
    }
}
