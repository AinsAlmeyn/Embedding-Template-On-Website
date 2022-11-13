using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace RESTGIYDIRME.Models.EntityData
{
    public class TeamEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string LinkFace { get; set; }
        public string LinkTwitter { get; set; }
        public string LinkLinkedin { get; set; }
        public string LinkInstagram { get; set; }
        public string Description { get; set; }
    }
}
