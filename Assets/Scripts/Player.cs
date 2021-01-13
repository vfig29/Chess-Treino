using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Time
{
    pretas,
    brancas
}
public class Player
{
    Time timeDoJogador; //peças brancas ou pretas.

    public Player()
    {

    }

    public Celula[,] TabuleiroDasBrancas()
    {
        //Metodo para inicializacao da posicao das brancas.
        Celula[,] tabuleiroInicial = new Celula[8, 2];
        //Inicializaçao dos Peoes:
        for (int x = 0; x < tabuleiroInicial.GetLength(0); x++)
        {
        }
        //Fim.

        return tabuleiroInicial;
    }

}
