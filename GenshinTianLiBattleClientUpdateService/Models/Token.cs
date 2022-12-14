using System.ComponentModel.DataAnnotations;

namespace GenshinTianLiBattleClientUpdateService.Models
{
    public class Token
    {
        public Guid? Id { get; set; } = Guid.NewGuid();
        public string TokenString { get; set; } = string.Empty;
        public DateTime? UpdateTime { get; set; } = DateTime.Now;
    }
}
