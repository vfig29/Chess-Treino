using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peao : Peça
{   
   
    public Peao()
    {
        attackLine = new List<Celula>();
        celulaAtual = GameCore.gameBoard.matrizPosicao[5, 1];
        Debug.Log("inicia Peao");

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
            Debug.Log("AtackLine: "+ celulaAtual.x+", "+attackLine[i].y);
        }

        Celula novoEspaco = GameCore.gameBoard.matrizPosicao[celulaAtual.x, vlrY];
        
        Debug.Log("Mover para: "+ celulaAtual.x +","+novoEspaco.y);
        
        Debug.Log("posso mover? "+ attackLine.Contains(novoEspaco));
        
        if(attackLine.Contains(novoEspaco)){
            celulaAtual = novoEspaco;
        }
        
        Debug.Log("Celula atual: " +celulaAtual.x +", "+ celulaAtual.y);

        SetAttackLine(); //Ultima chamada: Setar a nova attackline.

         for(int i = 0; i < attackLine.Count; i++){
            Debug.Log("AtackLine: "+ celulaAtual.x+", "+attackLine[i].y);
        }
    }

    public override void SetAttackLine()
    {

        if(attackLine.Count > 0){
            for(int i = (attackLine.Count-1); i >= 0; i--){
               attackLine.RemoveAt(i);
            }
        }


        int targetY = celulaAtual.y+1;
        int targetX = celulaAtual.x;
        if( celulaAtual.y == 1){
            if (targetX < Tabuleiro.sizeX && targetY < Tabuleiro.sizeY)
            {     
                if (targetY > 1)
                {
                    attackLine.Add(GameCore.gameBoard.matrizPosicao[celulaAtual.x, targetY]);
                    attackLine.Add(GameCore.gameBoard.matrizPosicao[celulaAtual.x, targetY+1]);
                }
            }
        }else{
            if (targetX < Tabuleiro.sizeX && targetY < Tabuleiro.sizeY)
            {     
                if (targetY > 1)
                {
                    attackLine.Add(GameCore.gameBoard.matrizPosicao[celulaAtual.x, targetY]);
                }
            }
        }

        
    }
}
