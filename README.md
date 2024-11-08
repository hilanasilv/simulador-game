<h1 align=center>Simulator Télos Nível 6 - POO 🚀</h1>

Este projeto simula um jogo com diferentes tipos de inimigos, com comportamentos específicos e habilidades, utilizando os conceitos de Programação Orientada a Objetos em C#. O projeto aplica conceitos de **encapsulamento**, **herança**, **polimorfismo** e **abstração**, com a criação de classes para representar os inimigos e suas subclasses.

## Funcionalidades

O projeto inclui os seguintes inimigos:

1. **Enemy**: Classe base que representa um inimigo genérico com atributos como saúde e velocidade, e métodos comuns para movimentação, receber dano e verificar se está morto.
2. **EnemyWithAttack**: Subclasse de `Enemy`, que adiciona a capacidade de atacar o jogador com uma força de ataque específica.
3. **FlyingEnemy**: Subclasse de `Enemy`, que representa inimigos que podem voar.
4. **JumpingEnemy**: Subclasse de `Enemy`, que representa inimigos que podem pular.
5. **StealthyEnemy**: Subclasse de `Enemy`, que representa inimigos que podem se tornar invisíveis.
6. **BossEnemy**: Subclasse especial de `Enemy`, com habilidades adicionais, como a capacidade de se enfurecer quando sua saúde fica abaixo de um certo valor.

## Estrutura do Projeto

### Métodos Principais

- **receiveDamage(damage)**: Reduz a saúde do inimigo com base no dano recebido.
- **displayStatus()**: Exibe a saúde e a velocidade do inimigo.
- **move()**: Move o inimigo de acordo com seu comportamento específico (pode ser sobrescrito nas subclasses).
- **attackPlayer(damage)**: Método específico da classe `EnemyWithAttack` para realizar um ataque no jogador.
- **fly()**: Método específico da classe `FlyingEnemy` para realizar o voo.
- **jump()**: Método específico da classe `JumpingEnemy` para realizar o salto.
- **invisible()**: Método específico da classe `StealthyEnemy` para realizar a invisibilidade.
- **infuriate()**: Método específico da classe `BossEnemy` para fazer o Boss se enfurecer, alterando seu comportamento.

### Conceitos Utilizados

- **Encapsulamento**: Atributos como saúde são protegidos e acessados por meio de métodos como `receiveDamage()`.
- **Herança**: Subclasses como `EnemyWithAttack`, `FlyingEnemy`, `JumpingEnemy`, `StealthyEnemy`, e `BossEnemy` herdam os comportamentos comuns de `Enemy`.
- **Polimorfismo**: Métodos como `move()` são sobrescritos nas subclasses para implementar comportamentos específicos, mas podem ser chamados de forma genérica através da classe base `Enemy`.
- **Abstração**: A classe `Enemy` abstrai os comportamentos comuns a todos os inimigos, enquanto as subclasses implementam comportamentos específicos.

## Como Executar


Para rodar este sistema, é necessário um ambiente de desenvolvimento com suporte a execução de programas em C#.

1. Clonar o Repositório ou baixar os arquivos do projeto:
   ```bash
   git clone https://github.com/hilanasilv/simulador-game.git
   ```

2. Abra o projeto no Visual Studio ou outro editor compatível.
3. Compile e execute o projeto.
4. Ao executar o programa, você verá mensagens no console indicando o comportamento dos inimigos, como movimento, ataques e mudanças de estado.

## Tecnologias Utilizadas
<div>
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white" alt="C#" style="border-radius:4px"/>
  <img src="https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white" alt="Visual Studio" style="border-radius:4px">
</div>