namespace Input
{
    public struct InputData
    {
        public int InputTime { get; }
        public int InputSpeed { get; }
        public int InputDistance { get; }

        public InputData(int inputTime, int inputSpeed, int inputDistance)
        {
            InputTime = inputTime;
            InputSpeed = inputSpeed;
            InputDistance = inputDistance;
        }
    }
}