namespace RESTGIYDIRME.Models.EntityData
{
    public class PortfolioSliderEntity
    {
        public int Id { get; set; }
        public int PortId { get; set; }
        public string Images { get; set; }
        public PortfolioEntity Portfolio { get; set; }
    }
}
