using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hands : MonoBehaviour
{

    public OVRInput.Controller controller;

    private float indexTriggerState = 0;
    private float handTriggerState = 0;
    private float oldIndexTriggerState = 0;

    public KeypadScript Keypad;

    // Update is called once per frame
    void Update()
    {
        oldIndexTriggerState = indexTriggerState;
        indexTriggerState = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, controller);
        handTriggerState = OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, controller);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "B button")
        {
            Keypad.PressB();
        }

        else if (collision.gameObject.tag == "O button")
        {
            Keypad.PressO();
        }

        else if (collision.gameObject.tag == "L button")
        {
            Keypad.PressL();
        }

        else if (collision.gameObject.tag == "G button")
        {
            Keypad.PressG();
        }

        else if (collision.gameObject.tag == "I button")
        {
            Keypad.PressI();
        }

        else if (collision.gameObject.tag == "H button")
        {
            Keypad.PressH();
        }

        else if (collision.gameObject.tag == "T button")
        {
            Keypad.PressT();
        }

        else if (collision.gameObject.tag == "A button")
        {
            Keypad.PressA();
        }

        else if (collision.gameObject.tag == "Y button")
        {
            Keypad.PressY();
        }

        else if (collision.gameObject.tag == "E button")
        {
            Keypad.PressE();
        }

        else if (collision.gameObject.tag == "S button")
        {
            Keypad.PressS();
        }

        else if (collision.gameObject.tag == "N button")
        {
            Keypad.PressN();
        }

        else if (collision.gameObject.tag == "U button")
        {
            Keypad.PressU();
        }

        else if (collision.gameObject.tag == "Green button")
        {
            Keypad.PressGreen();
        }

        else if (collision.gameObject.tag == "Red button")
        {
            Keypad.PressRed();
        }
    }
}
