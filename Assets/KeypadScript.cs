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

    public void PressB() 
    {
        input = input + "B";
        Debug.Log(input);
    }

    public void PressO()
    {
        input = input + "O";
        Debug.Log(input);
    }

    public void PressL() 
    {
        input = input + "L";
        Debug.Log(input);
    }

    public void PressG() 
    {
        input = input + "G";
        Debug.Log(input);
    }

    public void PressI()
    {
        input = input + "I";
        Debug.Log(input);
    }
    public void PressH()
    {
        input = input + "H";
        Debug.Log(input);
    }
    public void PressT() 
    {
        input = input + "T";
        Debug.Log(input);
    }
    public void PressA() 
    {
        input = input + "A";
        Debug.Log(input);
    }
    public void PressY()
    {
        input = input + "Y";
        Debug.Log(input);
    }
    public void PressE() 
    {
        input = input + "E";
        Debug.Log(input);
    }
    public void PressS() 
    {
        input = input + "S";
        Debug.Log(input);
    }
    public void PressN() 
    {
        input = input + "N";
        Debug.Log(input);
    }
    public void PressU() 
    {
        input = input + "U";
        Debug.Log(input);
    }
    public void PressRed() // Press to clear 
    {
        input = ""; // reset the input string to empty
        Debug.Log(input);
    }
    public void PressGreen()        //Press to submit
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

