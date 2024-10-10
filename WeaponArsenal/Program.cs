global using System.Text.Json;
using System.Net.Mail;
using System.Text.Json.Serialization; 


string textEnemy = File.ReadAllText("enemy.json");
List<Enemy> enemies = JsonSerializer.Deserialize<List<Enemy>>(textEnemy);

string textWeapon = File.ReadAllText("weapons.json");
List<Weapon> weapons = JsonSerializer.Deserialize<List<Weapon>>(textWeapon);

// Console.WriteLine(weapons[0].Name);
// Console.WriteLine(enemies[0].Name);

Console.WriteLine("How many attacks do you want to make?");

string atkNumAnswer = Console.ReadLine();

int atkNum = 0;

int.TryParse(atkNumAnswer, out atkNum);


// int totDmg = 0;

for (int i = 0; i < atkNum; i++)
{
    int dmg = weapons[0].Attack();    
    Console.WriteLine($"{dmg}");

    enemies[0].HitPoints -= dmg;
}

Console.WriteLine($"{enemies[0].Name} has {enemies[0].HitPoints} Hp left");

// Console.WriteLine($"The total damage was {totDmg}");

Console.ReadLine();


// Enemy firstEnemy = new Enemy()
// {
//     Name = "Bobo",
//     hitPoints = 75
// };
// string jsonEnemy = JsonSerializer.Serialize(firstEnemy);
// Console.WriteLine(jsonEnemy);
// File.WriteAllText("enemy.json", jsonEnemy);

// Weapon firstWeapon = new Weapon() 
// {
//     Name = "Katana",
//     DamageMin = 4,
//     DamageMax = 19
// };


// string jsonWeapon = JsonSerializer.Serialize(firstWeapon);
// Console.WriteLine(jsonWeapon);

// File.WriteAllText("weapons.json", jsonWeapon);