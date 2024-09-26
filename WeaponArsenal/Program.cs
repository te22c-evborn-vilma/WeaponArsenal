global using System.Text.Json;
using System.Net.Mail;
using System.Text.Json.Serialization; 

string textWeapon = File.ReadAllText("weapons.json");

List<Weapon> weapons = JsonSerializer.Deserialize<List<Weapon>>(textWeapon);

// Console.WriteLine(weapons[0].Name);

Console.WriteLine("How many attacks do you want to make?");

int atkNum = 0;




int totDmg = 0;

for (int i = 0; i < atkNum; i++)
{
    int dmg = weapons[0].Attack();
    totDmg += dmg;
}



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