using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Controller : MonoBehaviour // this will act as the parent class for each specific playable square
{
    public static Square ActiveSquare { get; private set; }
    public List<Square> squareList = new List<Square>(); // open up the list
    public TMP_Dropdown selectionMenu;
    public static Controller Prime;

    private void Start()
    {
        Prime = this;
    }

    public static void ActivateSquare(Square square) // these are responsible for assigned control to a specific square
    {
        if (ActiveSquare != null)
        {
            ActiveSquare.Chosen(false);
        }
        
        ActiveSquare = square;
        ActiveSquare.Chosen(true);
    }

    public void Chosen(int value)
    {
        ActivateSquare(squareList[value]);
    }
}
