namespace DIORPG.RPGCharacters;
public class Hunter : Character
{
    public override string Name { get; set; }


    public override void Atack(string name)
    {
        Name = name;

        Console.WriteLine($"{Name} atacou!");
    }
}
