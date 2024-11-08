using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Criando uma lista de inimigos
        List<Enemy> enemies = new List<Enemy>
        {
            new EnemyWithAttack(100, 3.0f, 20),
            new FlyingEnemy(90, 5.0f, 50.0f),
            new JumpingEnemy(70, 4.0f, 30.0f),
            new StealthyEnemy(70, 2.5f)
        };

        foreach (Enemy enemy in enemies)
        {
            enemy.Move();  // Chamando o método de movimento específico para cada tipo de inimigo
            enemy.DisplayStatus();  // Exibindo o status do inimigo

            // Comportamento específico de cada inimigo
            if (enemy is EnemyWithAttack enemyWithAttack)
            {
                enemyWithAttack.AttackPlayer();
            }
            if (enemy is FlyingEnemy flyingEnemy)
            {
                flyingEnemy.Fly();
            }
            if (enemy is JumpingEnemy jumpingEnemy)
            {
                jumpingEnemy.Jump();
            }
            if (enemy is StealthyEnemy stealthyEnemy)
            {
                stealthyEnemy.Invisible();
            }

            Console.WriteLine();
        }
    }
}
