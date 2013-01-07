namespace AboutLearningNinjectMVC4.Models
{
    public class DrugDealer:IDrugs
    {
        public string Use(string which)
        {
            return "You own me $1M for this " + which;
        }
    }
}