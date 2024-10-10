global using System.Text.Json;
using System.Net.Mail;
using System.Text.Json.Serialization; 

string textEnemy = File.ReadAllText("enemy.json");
List<Enemy> enemies = JsonSerializer.Deserialize<List<Enemy>>(textEnemy);

string textWeapon = File.ReadAllText("weapons.json");
List<Weapon> weapons = JsonSerializer.Deserialize<List<Weapon>>(textWeapon);

Console.WriteLine("Please choose a weapon (only write the number before the name)\n");

int length = weapons.Count;
for (int j = 0; j < length; j++)
{
    Console.WriteLine($"{j}. Name: {weapons[j].Name} || Minimum Damage: {weapons[j].DamageMin} || Maximum Damage: {weapons[j].DamageMax}\n");
}

string choice = Console.ReadLine();

int weaponChoice = 0;
int.TryParse(choice, out weaponChoice);

Console.WriteLine("How many attacks do you want to make? (only write the number of attacks)");

string atkNumAnswer = Console.ReadLine();

int atkNum = 0;

int.TryParse(atkNumAnswer, out atkNum);

for (int i = 0; i < atkNum; i++)
{
    int dmg = weapons[weaponChoice].Attack();    
    Console.WriteLine($"{dmg}");

    enemies[0].HitPoints -= dmg;
}

Console.WriteLine($"{enemies[0].Name} was hit {atkNum} number of time(s) and has {enemies[0].HitPoints} Hp left");

Console.ReadLine();




// Console.WriteLine(weapons[0].Name);
// Console.WriteLine(enemies[0].Name);
// int totDmg = 0;
// Console.WriteLine($"The total damage was {totDmg}");
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