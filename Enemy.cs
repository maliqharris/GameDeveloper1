public class Enemy
{
    string Name;
    int Health;
    public List<Attack> AttackList;

    public Enemy(string name)
    {
        Name = name;
        Health = 100;
        // As empty list
        AttackList = new List<Attack>();
    }
    public void RandomAttack()
    {
        Random random = new Random();
        int randInd = random.Next(0, AttackList.Count);
        Attack randomAttack = AttackList[randInd];
        Console.WriteLine(Name + " proforms " + randomAttack.Name);
    }
}