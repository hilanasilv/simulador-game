using System;

public class EnemyWithAttack : Enemy
{
    private int _attackPower;

    public int AttackPower
    {
        get => _attackPower;
        set => _attackPower = value;
    }

    public EnemyWithAttack(int health, float velocity, int attackPower)
        : base(health, velocity)
    {
        _attackPower = attackPower;
    }

    // Método de ataque
    public void AttackPlayer()
    {
        Console.WriteLine($"Atacando jogador com {AttackPower} de dano.");
    }
}