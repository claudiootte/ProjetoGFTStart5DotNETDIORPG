namespace DIORPG.RPGCharacters;
public class Hunter : Character
{
    public override string Name
    {
        get { return name; }
        set { name = value; }
    }


    public override void Atack(AtackWith atack)
    {
        Name = name;
        var AtackWithString = atack.ToString();

        Console.WriteLine($"{this.Name} atacou com {AtackWithString}");
    }

    public Hunter(string name)
    {
        this.Name = name;
    }


}
