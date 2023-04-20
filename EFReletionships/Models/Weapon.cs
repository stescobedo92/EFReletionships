using System.Text.Json.Serialization;

namespace EFReletionships.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Damage { get; set; } = 10;
        public int CharacterId { get; set; }
        [JsonIgnore]
        public Character Character { get; set; }

    }
}
