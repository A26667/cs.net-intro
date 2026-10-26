namespace InterfacesDemo.Interfaces;

public interface IHealer {
    // names of parameters do not need to match in subclasses' definition
    void Heal(int healthPoints);
}
