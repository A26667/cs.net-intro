using InterfacesDemo.Interfaces;
using InterfacesDemo.Classes;

IAnimal[] animals =
{
    new Dog(),
    new Cat()
};

foreach (var animal in animals)
{
    animal.Speak();
    if (animal is Dog dog)
        Console.WriteLine(dog.Play(10));
    else if (animal is Cat cat)
        Console.WriteLine(cat.Play(10));
}

ICombatant[] fighters =
{
    new Warrior { Name = "Aragorn", Health = 100, AttackPower = 25 },
    new Mage { Name = "Merlin", Health = 80, AttackPower = 40 }
};

foreach (var fighter in fighters)
{
    fighter.Attack();
    fighter.Defend();
    fighter.TakeDamage(10);
}
