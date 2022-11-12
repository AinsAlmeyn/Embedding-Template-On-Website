namespace RESTGIYDIRME.Models.EntityData
{
    public class PortfolioSlider
    {
        public int Id { get; set; }
        public int PortId { get; set; }
        public string Images { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
