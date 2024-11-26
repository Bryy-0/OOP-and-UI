using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class OOPandUI : MonoBehaviour
{
    public string labelText = " ";
    public string labelText2 = " ";

    [SerializeField] private int attackP1 = 10;
    [SerializeField] private int attackP2 = 20;
    [SerializeField] private int attackP3 = 30;

    [SerializeField] private int healthP1 = 100;
    [SerializeField] private int healthP2 = 120;
    [SerializeField] private int healthP3 = 130;

    [SerializeField] private int defenseP1 = 50;
    [SerializeField] private int defenseP2 = 45;
    [SerializeField] private int defenseP3 = 55;

    [SerializeField] private int manaP1 = 120;
    [SerializeField] private int manaP2 = 150;
    [SerializeField] private int manaP3 = 140;

    [SerializeField] private int speedP1 = 20;
    [SerializeField] private int speedP2 = 40;
    [SerializeField] private int speedP3 = 50;


    private void OnGUI()
    {
        GUI.Box(new Rect(115, 100, 100, 100), labelText);
        if (GUI.Button(new Rect(5, 5, 100, 50), "Player 1"))
        {
            labelText = "Name: Brylle \n\rAttack: " + attackP1 + "\n\rHealth: " + healthP1 + "\n\rDefense: " + defenseP1 + "\n\rMana: " + manaP1 + "\n\r Speed: " + speedP1;
        }

        if (GUI.Button(new Rect(115, 5, 100, 50), "Player 2"))
        {
            labelText = "Name: Macky \n\rAttack: " + attackP2 + "\n\rHealth: " + healthP2 + "\n\rDefense: " + defenseP2 + "\n\rMana: " + manaP2 + "\n\r Speed: " + speedP2;
        }

        if (GUI.Button(new Rect(225, 5, 100, 50), "Player 3"))
        {
            labelText = "Name: Jared \n\rAttack: " + attackP3 + "\n\rHealth: " + healthP3 + "\n\rDefense: " + defenseP3 + "\n\rMana: " + manaP3 + "\n\r Speed: " + speedP3;
        }



        GUI.Box(new Rect(450, 100, 100, 30), labelText2);
        if (GUI.Button(new Rect(400, 5, 100, 50), "Chest"))
        {
            labelText2 = "Coin";
        }
        if (GUI.Button(new Rect(510, 5, 100, 50), "Switch"))
        {
            labelText2 = "Door is Open";
        }
    }
}
