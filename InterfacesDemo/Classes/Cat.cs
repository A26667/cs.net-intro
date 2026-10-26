namespace InterfacesDemo.Classes;
using InterfacesDemo.Interfaces;

public class Cat : IAnimal {
    public void Speak() {
        Console.WriteLine("Meow!");
    }
    
    public string Play(int minutes) {
        Console.WriteLine($"You play with the cat for {minutes} minutes");
        return "Tired";
    }
}
