namespace app.webui.Models
{
    public class MenüModel
    {
        public string Name{get;set;}
        public bool Gived { get; set; }

        public MenüModel(string _name,bool _gived)
        {
            Name=_name;
            Gived=_gived;
        }
    }
}