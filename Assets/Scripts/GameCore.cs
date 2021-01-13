
using System.Collections.Generic;
using UnityEngine;

public class GameCore : MonoBehaviour
{
    public static Tabuleiro gameBoard = new Tabuleiro(); //variavel do tabuleiro.
    Player player1;//variavel do player 1.
    Player player2;//variavel do player 2.
    List<Command> commandLog = new List<Command>();
   
    Celula targetCell;
     Rei king;
    Peao pawn;
    void Start()
    {
        player1 = new Player();
        player2 = new Player();
        king = new Rei();
        pawn = new Peao();
        InvokeMovement(4, 1);
    }

    private void Update()
    {
        
    }

    public void InvokeAttack() //Metodo que será acessado ao invokar o ataque.
    {
       
        // commandLog.Add(new Attack());
    }

    public void InvokeMovement(int x, int y)
    {
        
        
        king.Movimentacao(x, y);
        pawn.Movimentacao(0, 2);
        
        
        commandLog.Add(new Movement()); //Metodo que será acessado ao invocar o ataque
    }

    public List<Celula> CheckAttackLine() // Retorna a linha de ataque de uma peça
    {
        return king.attackLine;
    }



}
