global using System.Text.Json;
using System.Text.Json.Serialization; 

string textWeapon = File.ReadAllText("weapons.json");

List<Weapon> weapons = JsonSerializer.Deserialize<List<Weapon>>(textWeapon);

Console.WriteLine(weapons[0].Name);

Console.ReadLine();





// Weapon firstWeapon = new Weapon() 
// {
//     Name = "Katana",
//     DamageMin = 4,
//     DamageMax = 19
// };

// string jsonWeapon = JsonSerializer.Serialize(firstWeapon);
// Console.WriteLine(jsonWeapon);

// File.WriteAllText("weapons.json", jsonWeapon);