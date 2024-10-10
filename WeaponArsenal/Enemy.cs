using System.Text.Json.Serialization;

public class Enemy
{
    [JsonInclude]
    public string Name;
    
    [JsonInclude]
    public int HitPoints;
}
