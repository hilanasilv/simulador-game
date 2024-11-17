using System;

public class FlyingEnemy : Enemy
{
    private float _altitude;

    public float Altitude
    {
        get => _altitude;
        set => _altitude = value;
    }

    public FlyingEnemy(int health, float velocity, float altitude)
        : base(health, velocity)
    {
        _altitude = altitude;
        EnemyType = "Flying";
    }

    // Método de voo
    public void Fly()
    {
        Console.WriteLine($"FlyingEnemy voando na altitude de: {Altitude}");
    }
}
