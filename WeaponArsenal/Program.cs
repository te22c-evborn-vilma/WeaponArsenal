global using System.Text.Json;
using System.Net.Mail;
using System.Text.Json.Serialization; 

string textEnemy = File.ReadAllText("enemy.json");
List<Enemy> enemies = JsonSerializer.Deserialize<List<Enemy>>(textEnemy);

string textWeapon = File.ReadAllText("weapons.json");
List<Weapon> weapons = JsonSerializer.Deserialize<List<Weapon>>(textWeapon);

Console.WriteLine($"Please choose a weapon to attack the enemy named {enemies[0].Name} with\n(You only need to write the number before the name)\n");

int length = weapons.Count;
for (int j = 0; j < length; j++)
{
    Console.WriteLine($"{j}. Name: {weapons[j].Name} || Minimum Damage: {weapons[j].DamageMin} || Maximum Damage: {weapons[j].DamageMax}\n");
}

string choice = Console.ReadLine();

int weaponChoice = 0;
int.TryParse(choice, out weaponChoice);

Console.WriteLine($"{enemies[0].Name} has {enemies[0].HitPoints} Hp");
Console.WriteLine("How many attacks do you want to make? \n(You only need to write the number of attacks)");
string atkNumAnswer = Console.ReadLine();

int atkNum = 0;
int.TryParse(atkNumAnswer, out atkNum);

for (int i = 0; i < atkNum; i++)
{
    int dmg = weapons[weaponChoice].Attack();    
    Console.WriteLine($"-{dmg}");

    enemies[0].HitPoints -= dmg;
}

if (enemies[0].HitPoints > 0)
{
    Console.WriteLine($"{enemies[0].Name} was hit {atkNum} time(s) and has {enemies[0].HitPoints} Hp left");
}
else 
{
    Console.WriteLine($"{enemies[0].Name} took a lot of damage and is dead");
}

Console.ReadLine();

/*
+ Se till att frågor upprepas om spelaren svarar något som inte finns
+ Skriv kommentarer som förtydligar koden
+ Loop som avslutas när fiendens hp är 0 eller mindre - spelaren får attackera på nytt tills fienden har 0 hp
+ Flera fiender
+ Spelaren får välja vem som ska attackeras först
+ eller så väljs en random fiende
*/



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