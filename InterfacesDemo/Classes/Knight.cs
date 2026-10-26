namespace InterfacesDemo.Classes;
using InterfacesDemo.Interfaces;

// classes in C# allow multiple inheritance only from interfaces, not classes
public class Knight : IAttack, IDefend {
    void IAttack.Attack() {
        Console.WriteLine("Knight attacks with a sword.");
    }

    void IDefend.Attack() {
        Console.WriteLine("Knight raises a shield to defend.");
    }
}