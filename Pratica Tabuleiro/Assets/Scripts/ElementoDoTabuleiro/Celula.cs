using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class Celula : MonoBehaviour
{
    public int x;//coordenada x, no tabuleiro.
    public int y;//coordenada y, no tabuleiro.
    public Peça peçaAtual;//peça que se encontra a cima da celula.
    public bool attackLine; //Booleano que define se esta celula está em uma linha de ataque.
   
    public void SetCellPosition(int _x, int _y)
    {
        x = _x;
        y = _y;
        attackLine = false;
        InitCellAttributes();//Inicializa atributos iniciais da celula;
    }

    private void InitCellAttributes()
    {
        SyncTransformWithPosition();//Altera os valores do transform do Celula_GB;
        SetCellTriggerCollider();//Adiciona e configura um colisor para a instancia de celula.
    }

    private void SyncTransformWithPosition()
    {
        //transform.position.x = x;
        //transform.position.y = y;

        //NOTA: Talvez precise puxar o graphicScale.(OBSERVAR).
        transform.localPosition = new Vector2(x, y);//Cria um vetor com os dados do script e joga dentro do transform.
    }

    private void SetCellTriggerCollider()
    {
        int scaleGraphic = Tabuleiro.boardGraphicScale;
        BoxCollider2D createdCollider = this.gameObject.AddComponent<BoxCollider2D>();//Adiciona um colisor do tipo: BoxCollider2D dentro do GameObject Celula_GB.
        createdCollider.size = createdCollider.size * scaleGraphic;


    }

    public void SetPieceOnCell(Peça peçaAdicionada)
    {
        this.peçaAtual = peçaAdicionada;
        peçaAdicionada.celulaAtual = this;
    }
}
