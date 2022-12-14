using System.ComponentModel.DataAnnotations;

namespace GenshinTianLiBattleClientUpdateService.Models
{
    public class Artifact
    {
        public Guid? Id { get; set; } = Guid.NewGuid();
        [Required]
        public string Version { get; set; } = string.Empty;
        [Required]
        public string DownloadUrl { get; set; } = string.Empty;
        [Required]
        public string Hash { get; set; } = string.Empty;
        [Required]
        public string BuildVersion { get; set; } = string.Empty;
        public DateTime? UpdateTime { get; set; } = DateTime.Now;
    }
}
