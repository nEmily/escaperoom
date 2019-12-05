using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeypadScript : MonoBehaviour
{


    public string curPassword = "THEGOATISBILLY";
    public string input;

    public Button ButtonB;
    public Button ButtonO;
    public Button ButtonL;
    public Button ButtonG;
    public Button ButtonI;
    public Button ButtonH;
    public Button ButtonT;
    public Button ButtonA;
    public Button ButtonY;
    public Button ButtonE;
    public Button ButtonS;
    public Button ButtonN;
    public Button ButtonU;
    public Button RedButton;
    public Button GreenButton;

    public GameObject WoodenBeam;

    void Start()
    {
        ButtonB.GetComponent<Button>().onClick.AddListener(PressB);
        ButtonO.GetComponent<Button>().onClick.AddListener(PressO);
        ButtonL.GetComponent<Button>().onClick.AddListener(PressL);
        ButtonG.GetComponent<Button>().onClick.AddListener(PressG);
        ButtonI.GetComponent<Button>().onClick.AddListener(PressI);
        ButtonH.GetComponent<Button>().onClick.AddListener(PressH);
        ButtonT.GetComponent<Button>().onClick.AddListener(PressT);
        ButtonA.GetComponent<Button>().onClick.AddListener(PressA);
        ButtonY.GetComponent<Button>().onClick.AddListener(PressY);
        ButtonE.GetComponent<Button>().onClick.AddListener(PressE);
        ButtonS.GetComponent<Button>().onClick.AddListener(PressS);
        ButtonN.GetComponent<Button>().onClick.AddListener(PressN);
        ButtonU.GetComponent<Button>().onClick.AddListener(PressU);
        RedButton.GetComponent<Button>().onClick.AddListener(PressRed);
        GreenButton.GetComponent<Button>().onClick.AddListener(PressGreen);
    }

    void PressB() //Press Button One on Keypad
    {
        input = input + "B";
    }

    void PressO() //Press Button Two on Keypad
    {
        input = input + "O";
    }

    void PressL() //Press Button Three on Keypad
    {
        input = input + "L";
    }

    void PressG() //Press Button Four on Keypad
    {
        input = input + "G";
    }

    void PressI() //Press Button Five on Keypad
    {
        input = input + "I";
    }
    void PressH() //Press Button Six on Keypad
    {
        input = input + "H";
    }
    void PressT() //Press Button Seven on Keypad
    {
        input = input + "T";
    }
    void PressA() //Press Button Eight on Keypad
    {
        input = input + "A";
    }
    void PressY() //Press Button Nine on Keypad
    {
        input = input + "Y";
    }
    void PressE() //Press Button Zero on Keypad
    {
        input = input + "E";
    }
    void PressS() //Press Button Zero on Keypad
    {
        input = input + "S";
    }
    void PressN() //Press Button Zero on Keypad
    {
        input = input + "N";
    }
    void PressU() //Press Button Zero on Keypad
    {
        input = input + "U";
    }
    void PressRed() // When you press clear 
    {
        input = ""; // reset the input string to empty
    }
    void PressGreen()        //Press the GreenButton(GoButton)
    {
        if (input == curPassword)        // if it is right 
        {
            Debug.Log("CorrectPassword!!!");

            WoodenBeam.gameObject.SetActive(false);

        }
        else
        {
            Debug.Log("Wrong :(");
        }
    }
}

