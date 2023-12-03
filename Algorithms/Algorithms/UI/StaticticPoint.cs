namespace UI
{
    public struct StaticticPoint
    {
        public StaticticPoint(int i, int d, double t) 
        {
            Iteration = i;
            Distance = d;
            Temperature = t;
        } 

        public int Iteration { get; }
        public int Distance { get; }
        public double Temperature { get; }
    }
}
