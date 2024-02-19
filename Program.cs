int heroHealth = 10;
int montsterHealth = 10;
Random random = new Random();
int heroAttack = random.Next(1, 11);
int monsterAttack = random.Next(1, 11);

while (heroHealth > 0 && montsterHealth > 0)
{
    Console.WriteLine("Hero attacks the monster for " + heroAttack + " damage!");
    montsterHealth -= heroAttack;
    Console.WriteLine("Monster has " + montsterHealth + " health left!");
    if (montsterHealth <= 0) continue;
    Console.WriteLine("Monster attacks the hero for " + monsterAttack + " damage!");
    heroHealth -= monsterAttack;
    Console.WriteLine("Hero has " + heroHealth + " health left!");
}
if (heroHealth <= 0)
{
    Console.WriteLine("Hero has been defeated!");
}
else
{
    Console.WriteLine("Monster has been defeated!");
}
