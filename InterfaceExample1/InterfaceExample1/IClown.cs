namespace InterfaceExample1;

public interface IClown
{
    string FunnyThingIHave { get;  }
    void Honk();
}

interface IScaryClown : IClown
{
    string ScaryThingIHave { get; }
    void ScaryLittleChildren();
}