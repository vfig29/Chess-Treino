using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rei : Peça
{

    public override void Ataque()
    {
        
    }
    public override void Movimentacao()
    {

        SetAttackLine(); //Ultima chamada: Setar a nova attackline.
    }
    public override void SetAttackLine()
    {
        attackLine = new List<Celula>();

        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {
                if (!(i == 0 && j == 0))
                {
                    int targetX = celulaAtual.x + i;
                    int targetY = celulaAtual.y + j;
                    if (targetX < Tabuleiro.sizeX && targetY < Tabuleiro.sizeY)
                    {
                        if (targetX > 0 && targetY > 0)
                        {
                            attackLine.Add(GameCore.gameBoard.matrizPosicao[targetX, targetY]);
                        }
                    }
                }
            }
        }

    }
}
