namespace DIORPG.RPGCharacters;
public abstract class Character
{
    protected string name;
    // abstract method
    public abstract string Name
    {
        get;
        set;
    }

    public abstract void Atack(AtackWith atack);



}
