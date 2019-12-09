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

    public void PressB() //Press Button One on Keypad
    {
        input = input + "B";
        Debug.Log(input);
    }

    public void PressO() //Press Button Two on Keypad
    {
        input = input + "O";
        Debug.Log(input);
    }

    public void PressL() //Press Button Three on Keypad
    {
        input = input + "L";
        Debug.Log(input);
    }

    public void PressG() //Press Button Four on Keypad
    {
        input = input + "G";
        Debug.Log(input);
    }

    public void PressI() //Press Button Five on Keypad
    {
        input = input + "I";
        Debug.Log(input);
    }
    public void PressH() //Press Button Six on Keypad
    {
        input = input + "H";
        Debug.Log(input);
    }
    public void PressT() //Press Button Seven on Keypad
    {
        input = input + "T";
        Debug.Log(input);
    }
    public void PressA() //Press Button Eight on Keypad
    {
        input = input + "A";
        Debug.Log(input);
    }
    public void PressY() //Press Button Nine on Keypad
    {
        input = input + "Y";
        Debug.Log(input);
    }
    public void PressE() //Press Button Zero on Keypad
    {
        input = input + "E";
        Debug.Log(input);
    }
    public void PressS() //Press Button Zero on Keypad
    {
        input = input + "S";
        Debug.Log(input);
    }
    public void PressN() //Press Button Zero on Keypad
    {
        input = input + "N";
        Debug.Log(input);
    }
    public void PressU() //Press Button Zero on Keypad
    {
        input = input + "U";
        Debug.Log(input);
    }
    public void PressRed() // When you press clear 
    {
        input = ""; // reset the input string to empty
        Debug.Log(input);
    }
    public void PressGreen()        //Press the GreenButton(GoButton)
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

