namespace InheritanceMinigame.Classes;

public class EliteWarrior : Warrior {
    public EliteWarrior(string name) : base($"Elite Member {name}") {
        ShieldBlock *= 2;
        AttackPower *= 2;
    }
}