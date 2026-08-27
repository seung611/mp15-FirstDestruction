namespace mp15_FirstDestruction;

public class Monster : IDamageable
{
    public int Health { get; protected set; }
    public string Name;
    Monster(int health, string name)
    {
        Health = health;
        Name = name;
    }
    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name}가 {damage}데미지를 입었습니다");
    }
}