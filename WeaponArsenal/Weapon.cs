using System.Text.Json.Serialization;

public class Weapon
{
    [JsonInclude]
    public string Name;

    [JsonInclude]
    public int DamageMin;

    [JsonInclude]
    public int DamageMax;

    // public void Attack(int dmg)
    // {

    // }
}
