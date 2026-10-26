namespace InterfacesDemo.Classes;
using InterfacesDemo.Interfaces;

public class Mage : ICombatant
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }

    public void Attack()
    {
        Console.WriteLine($"{Name} casts a fireball for {AttackPower} damage.");
    }

    public void Defend()
    {
        Console.WriteLine($"{Name} creates a magical barrier.");
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage.");
    }
}
