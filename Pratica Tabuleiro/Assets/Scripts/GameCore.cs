
using System.Collections.Generic;
using UnityEngine;

public class GameCore : MonoBehaviour
{
    public static Tabuleiro gameBoard = new Tabuleiro(); //variavel do tabuleiro.
    Player player1;//variavel do player 1.
    Player player2;//variavel do player 2.
    List<Command> commandLog = new List<Command>();
    Peça attackActor;
    Celula targetCell;
    void Start()
    {
        player1 = new Player();
        player2 = new Player();
    }

    private void Update()
    {
        
    }

    public void InvokeAttack() //Metodo que será acessado ao invokar o ataque.
    {
        commandLog.Add(new Attack());
    }

    public void InvokeMovement()
    {
        commandLog.Add(new Movement()); //Metodo que será acessado ao invocar o ataque
    }

    public List<Celula> CheckAttackLine() // Retorna a linha de ataque de uma peça
    {
        return attackActor.attackLine;
    }



}
