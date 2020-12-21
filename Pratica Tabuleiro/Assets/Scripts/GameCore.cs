
using UnityEngine;

public class GameCore : MonoBehaviour
{
    Tabuleiro tabuleiroDoGame; //variavel do tabuleiro.
    Player player1;//variavel do player 1.
    Player player2;//variavel do player 2.
    void Start()
    {
        player1 = new Player();
        player2 = new Player();
        tabuleiroDoGame = new Tabuleiro();
    }



}
