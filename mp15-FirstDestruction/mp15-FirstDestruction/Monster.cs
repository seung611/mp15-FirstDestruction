namespace mp15_FirstDestruction;

public class Monster : IDamageable
{
    public int health;
    public string name;
    
    public int Health { get; protected set; }
    public string Name { get; protected set; }
    
    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"이름: {name} damage: {damage} 입었다.");
    }
}