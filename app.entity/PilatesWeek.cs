namespace app.entity
{
    public class PilatesWeek : BaseClass
    {
        public string Name{get;set;}
        public bool IsDone { get; set; }
        public int PilatesId { get; set; }
        public Pilates Pilates { get; set; }
        public Calendar calendar { get; set; }
    }
}