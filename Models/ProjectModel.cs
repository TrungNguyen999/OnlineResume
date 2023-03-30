using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace OnlineResume.Models
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        [JsonPropertyName("Link")]
        public string? ProjectLink { get; set; }
        [DataType(DataType.Date)]
        public DateTime? CreatedDate { get; set; }
    }
}
