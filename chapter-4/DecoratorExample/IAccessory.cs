namespace DecoratorExample;

public interface IAccessory
{
    public string Name { get; set; }
    public void Activate();
}