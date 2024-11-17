using System;

public class StealthyEnemy : Enemy
{
    public StealthyEnemy(int health, float velocity)
        : base(health, velocity)
    { 
        EnemyType = "Stealthy"; 
    }

    // Método de invisibilidade
    public void Invisible()
    {
        Console.WriteLine("O inimigo ficou invisível.");
    }
}
