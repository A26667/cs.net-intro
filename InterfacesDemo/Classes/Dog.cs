namespace InterfacesDemo.Classes;
// "using" directive to reference the namespace that contains the interfaces
using InterfacesDemo.Interfaces;

public class Dog : IAnimal {    // implements this interface
    public void Speak() {
        Console.WriteLine("Woof!");
    }
    
    public string Play(int minutes) {
        Console.WriteLine($"You play with the dog for {minutes} minutes");
        if (minutes > 15)
            return "Tired";
        return ":)";
    }
}
