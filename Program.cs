
int heroHP = 10;
int monsterHP = 10;
Random random = new Random();

while (heroHP > 0 && monsterHP > 0)
{


  int heroDamage = random.Next(1, 11);
  monsterHP -= heroDamage;
  Console.WriteLine($"Monster was damaged and lost {heroDamage} health and now has {monsterHP} health.");

  if (monsterHP <= 0)
  {
    Console.WriteLine("Hero wins!");
    break;
  }

  int monsterDamage = random.Next(1, 11);
  heroHP -= monsterDamage;
  Console.WriteLine($"Hero was damaged and lost {monsterDamage} health and now has {heroHP} health.");

  if (heroHP <= 0)
  {
    Console.WriteLine("Monster wins!");
    break;
  }
}