using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Piece
{
    King,
    Pawn,
    Queen,
    Knight,
    Rook,
    Bishop,
}
public static class PieceLoader
{
    
    public static GameObject LoadPiece(Piece loadedPiece)
    {
        GameObject searchedObject;
        string piecePath = "";
        switch(loadedPiece)
        {
            case Piece.King:
                piecePath = "King_GB";
                break;
            case Piece.Pawn:
                piecePath = "Pawn_GB";
                break;
        }

        searchedObject = Resources.Load<GameObject>(piecePath);
        return searchedObject;
    }

}
