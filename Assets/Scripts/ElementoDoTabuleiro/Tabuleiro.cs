﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tabuleiro
{
    public static int sizeX = 8;
    public static int sizeY = 8;
    public Celula[,] matrizPosicao = new Celula[sizeX, sizeY];//posicoes das celulas do tabuleiro.

    public Tabuleiro()
    {
        //Inicializacao por meio da instanciacao das celulas do tabuleiro.
        for (int x = 0; x < matrizPosicao.GetLength(0); x++)
        {
            for (int y = 0; y < matrizPosicao.GetLength(1); y++)
            {
                matrizPosicao[x, y] = new Celula(x,y);
            }
        }
    }
}
