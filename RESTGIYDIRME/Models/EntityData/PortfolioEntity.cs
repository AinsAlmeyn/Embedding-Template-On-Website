namespace RESTGIYDIRME.Models.EntityData
{
    public class PortfolioEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string Client { get; set; }
        public string Place { get; set; }
        public int Rating { get; set; }
        public string GalleryImage { get; set; }

        public ICollection<PortfolioSliderEntity> PortfolioSliders { get; set; }
    }
}
