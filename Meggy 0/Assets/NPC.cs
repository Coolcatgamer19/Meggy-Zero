using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    //Current Line Int

    public int CurrentLine;
   

    //Texts

    public string Line1;
    public string Line2;
    public string Line3;
    public string Line4;
    public string Line5;
    public string Line6;
    public string Line7;
    public string Line8;
    public string Line9;
    public string Line10;

    //TextBox

    public Text NpcBox;

    // Update is called once per frame
    void Update()
    {

        //Chosing line

        if (Input.GetKeyDown(KeyCode.E))
        {
            CurrentLine += 1;
        }

        // setting text values

        if (CurrentLine == 1)
        {
            NpcBox.text = Line1;
        }

        if (CurrentLine == 2)
        {
            NpcBox.text = Line2;
        }
        if (CurrentLine == 3)
        {
            NpcBox.text = Line3;
        }

        if (CurrentLine == 4)
        {
            NpcBox.text = Line4;
        }
        if (CurrentLine == 5)
        {
            NpcBox.text = Line5;
        }

        if (CurrentLine == 6)
        {
            NpcBox.text = Line6;
        }
        if (CurrentLine == 7)
        {
            NpcBox.text = Line7;
        }

        if (CurrentLine == 8)
        {
            NpcBox.text = Line8;
        }
        if (CurrentLine == 9)
        {
            NpcBox.text = Line9;
        }

        if (CurrentLine == 10)
        {
            NpcBox.text = Line10;
        }

        if (CurrentLine == 11)
        {
            NpcBox.text = ("");
        }
    }
}