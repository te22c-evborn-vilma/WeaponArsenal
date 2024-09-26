global using System.Text.Json;
using System.Text.Json.Serialization; 

Weapon firstWeapon = new Weapon() 
{
    Name = "Katana",
    DamageMin = 4,
    DamageMax = 19
};

string jsonWeapon = JsonSerializer.Serialize(firstWeapon);
Console.WriteLine(jsonWeapon);

File.WriteAllText("weapons.json", jsonWeapon);

Console.ReadLine();