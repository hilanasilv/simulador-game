﻿using System;

public class BossEnemy : Enemy
{
    private bool _isInfuriated;

    // Propriedade que acessa o estado de fúria do Chefão
    public bool IsInfuriated
    {
        get => _isInfuriated;
        set => _isInfuriated = value;
    }

    public BossEnemy(int health, float velocity) : base(health, velocity)
    {
        _isInfuriated = false;
    }

    // Se o Chefão estiver morto ou a saúde for maior que 50, ele não fica com raiva
    public void Infuriate()
    {
        if (IsDead() || Health > 50) return;
        _isInfuriated = true;
        Console.WriteLine("Chefão com raiva!");
    }

    // O movimento do Chefão muda de acordo com o estado de fúria
    public override void Move()
    {
        if (_isInfuriated)
        {
            Console.WriteLine("Chefão se movendo de forma agressiva!");
        }
        else
        {
            Console.WriteLine("Chefão se movendo.");
        }
    }
}