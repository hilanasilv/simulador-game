using System;

public class Enemy
{
    private int _maxHealth;
    private int _currentHealth;
    private float _velocity;

    // Propriedade que indica o tipo de inimigo
    public string EnemyType { get; protected set; }

    // Acessa a saúde do inimigo
    public int Health
    {
        get => _currentHealth;
        set => _currentHealth = (value < 0) ? 0 : (value > _maxHealth) ? _maxHealth : value;
    }

    // Acessa a velocidade do inimigo
    public float Velocity
    {
        get => _velocity;
        set => _velocity = value;
    }

    // Inicializa o inimigo com sáude e velocidade
    public Enemy(int initialHealth, float initialVelocity)
    {
        _maxHealth = initialHealth;
        _currentHealth = initialHealth;
        _velocity = initialVelocity;
    }

    // Método para aplicar dano ao inimigo
    public void ReceiveDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"Enemy recebeu {damage} de dano. Saúde atual: {Health}");
        if (IsDead())
        {
            Console.WriteLine("Enemy morreu.");
        }
    }

    // Método para verificar se o inimigo está morto 
    public bool IsDead()
    {
        return Health <= 0;
    }

    // Método de movimento centralizado
    public void Move()
    {
        if (EnemyType == "Flying")
        {
            Console.WriteLine("FlyingEnemy se movendo pelo ar.");
        }
        else if (EnemyType == "Jumping")
        {
            Console.WriteLine("JumpingEnemy está pulando.");
        }
        else if (EnemyType == "Stealthy")
        {
            Console.WriteLine("StealthyEnemy está se movendo nas sombras.");
        }
        else if (EnemyType == "Boss")
        {
            Console.WriteLine("Chefão está se movendo.");
        }
        else
        {
            Console.WriteLine($"Enemy se movendo com {Velocity} de velocidade.");
        }
    }

    // Método para exibir o status do inimigo
    public void DisplayStatus()
    {
        Console.WriteLine($"Saúde: {Health}, Velocidade: {Velocity}");
    }
}