using System;

namespace InheritanceMinigame.Classes;

public class Dragon : Character
{
    public Dragon(string name) : base(name, 200, 20) {
        BattleCry = "Woof!";
    }

    public override void PerformAttack(Character target)
    {
        Console.WriteLine($"{Name} cries '{BattleCry}' and breathes devastating fire across the battlefield!");
        target.TakeDamage(AttackPower);
    }
}
