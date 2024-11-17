using System;

public class JumpingEnemy : Enemy
{
    private float _altitude;

    public float Altitude
    {
        get => _altitude;
        set => _altitude = value;
    }

    public JumpingEnemy(int health, float velocity, float altitude)
        : base(health, velocity)
    {
        _altitude = altitude;
        EnemyType = "Jumping";
    }

    // Método de salto
    public void Jump()
    {
        Console.WriteLine("JumpingEnemy está pulando para a frente!");
    }
}
