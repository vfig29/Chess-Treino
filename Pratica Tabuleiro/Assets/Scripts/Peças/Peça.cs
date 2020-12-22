using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Peça : MonoBehaviour
{
    //Classe pai das peças do jogo. Todas as peças devem herdar desta classe.
    public List<Celula> attackLine;
    public Celula celulaAtual;

    public abstract void Movimentacao();
    public abstract void Ataque();
    public abstract void SetAttackLine(); // Existe  para determinar as casas ameaçadas pela peça.
}
