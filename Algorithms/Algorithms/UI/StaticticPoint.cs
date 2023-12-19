namespace UI
{
    public struct StaticticPoint
    {
        public StaticticPoint(int i, int d) 
        {
            Iteration = i;
            Distance = d;
        } 

        public int Iteration { get; }
        public int Distance { get; }
    }
}
