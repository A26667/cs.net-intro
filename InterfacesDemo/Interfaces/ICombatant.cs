namespace InterfacesDemo.Interfaces;

public interface ICombatant
{
    string Name { get; set; }
    int Health { get; set; }
    int AttackPower { get; set; }

    void Attack();
    void Defend();
    void TakeDamage(int damage);
}
