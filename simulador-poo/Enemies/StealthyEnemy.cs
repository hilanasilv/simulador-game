using System;

public class StealthyEnemy : Enemy
{
    public StealthyEnemy(int health, float velocity)
        : base(health, velocity)
    { }

    // Método de invisibilidade
    public void Invisible()
    {
        Console.WriteLine("O inimigo ficou invisível.");
    }

    public override void Move()
    {
        Console.WriteLine("StealthyEnemy está se movendo nas sombras.");
    }
}
