using System.Text.Json.Serialization;

namespace EFReletionships.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string RpgClass { get; set; } = "Knight";
        public int UserId { get; set; }
        [JsonIgnore]
        public User User { get; set; }
        public int WeaponId { get; set; }
        public Weapon Weapon { get; set; }
    }
}
