using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celula 
{
    public int x;//coordenada x, no tabuleiro.
    public int y;//coordenada y, no tabuleiro.
    public Peça peçaAtual;//peça que se encontra a cima da celula.
    public bool attackLine;
    public Celula(int _coordX, int _coordY)
    {
        x = _coordX;
        y = _coordY;
    }
    
}
