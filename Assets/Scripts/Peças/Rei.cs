using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rei : Peça
{
    public Rei()
    {
        attackLine = new List<Celula>();
        celulaAtual = GameCore.gameBoard.matrizPosicao[5, 0];
        Debug.Log("inicia rei");
       
        SetAttackLine();
       

    }

    public override void Ataque()
    {
        
    }
    public override void Movimentacao(int vlrX, int vlrY)
    {
        Debug.Log("Celula atual: " + celulaAtual.x +","+ celulaAtual.y);
        Debug.Log("Possiveis movimentos: ");

        for(int i = 0; i < attackLine.Count; i++){
            Debug.Log("AtackLine: " + attackLine[i].x +", "+ attackLine[i].y);
            
        }

        Celula novoEspaco = GameCore.gameBoard.matrizPosicao[vlrX, vlrY];
        
        Debug.Log("Mover para: "+ novoEspaco.x +","+novoEspaco.y);
        
        Debug.Log("posso mover? "+ attackLine.Contains(novoEspaco));
        
        if(attackLine.Contains(novoEspaco)){
            celulaAtual = novoEspaco;
        }
        
        Debug.Log("Celula atual: " +celulaAtual.x +", "+ celulaAtual.y);

        SetAttackLine(); //Ultima chamada: Setar a nova attackline.

        for(int i = 0; i < attackLine.Count; i++){
            Debug.Log("AtackLine: " + attackLine[i].x +", "+ attackLine[i].y);
            
        }
    }
    public override void SetAttackLine()
    {
        //casa para onde o rei naõ pode ir
        GameCore.gameBoard.matrizPosicao[4, 0].attackLine = true;
         
        if(attackLine.Count > 0){
           
            for(int i = (attackLine.Count-1); i >=0  ; i--){
               attackLine.RemoveAt(i);
            }
        }
         
       
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
                        
                        if (targetX >= 0 && targetY >= 0 && GameCore.gameBoard.matrizPosicao[targetX, targetY].attackLine == false)
                        {
                            
                            attackLine.Add(GameCore.gameBoard.matrizPosicao[targetX, targetY]);
                        }
                    }
                }
            }
        }

    }

}
