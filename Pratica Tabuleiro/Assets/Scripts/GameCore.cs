
using System.Collections.Generic;
using UnityEngine;

public class GameCore : MonoBehaviour
{
    public static Tabuleiro gameBoard; //variavel do tabuleiro.
    Player player1;//variavel do player 1.
    Player player2;//variavel do player 2.
    List<Command> commandLog = new List<Command>();

    void Start()
    {
        gameBoard = BoardCreation(); //Tabuleiro Inicializado.
        Instantiate(PieceLoader.LoadPiece(Piece.King));
        player1 = new Player();
        player2 = new Player();
    }

    Tabuleiro BoardCreation()
    {
        GameObject board_GB = new GameObject("Board_BG");// Cria o GameObject do tabuleiro.
        Tabuleiro tabuleiroCriado = board_GB.AddComponent<Tabuleiro>(); // Cria o o Script do tipo "Tabuleiro" e joga dentro do GameObject.
        return tabuleiroCriado;
    }

    private void Update()
    {
        
    }

    public void InvokeAttack()
    {
       
        commandLog.Add(new Attack());
    }

    public void InvokeMovement(int x, int y)
    {
        commandLog.Add(new Movement()); //Metodo que será acessado ao invocar o ataque
    }
}
