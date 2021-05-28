namespace app.entity
{
    public class DietMenü:BaseClass
    {
        public string Path{get;set;}
        public bool Gender{get;set;}
        public int? dietWekklyId{get;set;}
        public DietWekkly dietWekkly{get;set;}
        public bool TwoMeals{get;set;}
        public int Weight{get;set;}
        public string Recipe{get;set;}

    }
}