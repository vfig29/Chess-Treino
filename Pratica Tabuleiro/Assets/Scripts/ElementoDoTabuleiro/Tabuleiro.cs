using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tabuleiro : MonoBehaviour
{
    public static int boardGraphicScale = 5;
    public static int sizeX = 8;
    public static int sizeY = 8;
    public Celula[,] matrizPosicao = new Celula[sizeX, sizeY];//posicoes das celulas do tabuleiro.

    public void Start()
    {
        //Inicializacao por meio da instanciacao das celulas do tabuleiro.
        for (int x = 0; x < matrizPosicao.GetLength(0); x++)
        {
            for (int y = 0; y < matrizPosicao.GetLength(1); y++)
            {
                matrizPosicao[x, y] = CellCreation(x, y);
            }
        }
    }


    Celula CellCreation(int coordx, int coordy)
    {
        GameObject celula_GB = new GameObject("Celula_GB");
        celula_GB.transform.parent = this.gameObject.transform;
        Celula scriptCelula = celula_GB.AddComponent<Celula>();
        scriptCelula.SetCellPosition(coordx, coordy);
        return scriptCelula;
    }

}
