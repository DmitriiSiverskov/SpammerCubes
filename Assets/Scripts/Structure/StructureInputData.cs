namespace Structure
{
    public readonly struct StructureInputData
    {
        public float _time { get; }
        public float _speed { get; }
        public float _distance { get; }

        public StructureInputData(float time, float speed, float distance)
        {
            _time = time;
            _speed = speed;
            _distance = distance;
        }
    }
}