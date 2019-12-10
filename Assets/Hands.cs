﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hands : MonoBehaviour
{

    public OVRInput.Controller controller;

    private float indexTriggerState = 0;
    private float handTriggerState = 0;
    private float oldIndexTriggerState = 0;

    private bool hasFeather = false;
    private GameObject feather;

    private GameObject scroll;

    private bool hasUk = false;
    private GameObject ukulele;

    public Vector3 holdPosition = new Vector3(0, -0.025f, 0.03f);
    public Vector3 holdRotation = new Vector3(0, 180, 0);

    public KeypadScript Keypad;

    public AudioSource ukuleleSound;

    // Update is called once per frame
    void Update()
    {
        oldIndexTriggerState = indexTriggerState;
        indexTriggerState = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, controller);
        handTriggerState = OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, controller);

        if (hasFeather)
        {
            if (handTriggerState < 0.6f)
            {
                releaseFeather();
            }
        }

        if (hasUk)
        {
            //display text, "Press to play"
            if (Input.GetButtonDown("Space"))
            {
                ukuleleSound.Play(0);
            }
        }
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

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Feather"))
        {
            if (handTriggerState > 0.9f && !hasFeather)
            {
                print("Grabbing feather.");
                Grab(feather);
            }
        }

        if (other.CompareTag("Intro Letter"))
        {
            if (hasFeather)
            {
                updateScroll();
            }
        }

        else if (other.CompareTag("Ukulele"))
        {
            if (handTriggerState > 0.9f && !hasUk)
            {
                print("Grabbing ukulele.");
                Grab(ukulele);
            }
        }
    }

    void Grab(GameObject obj)
    {
        if (obj.tag == "feather")
        {
            hasFeather = true;
            feather = obj;

            feather.transform.parent = transform;

            feather.transform.localPosition = holdPosition;
            feather.transform.localEulerAngles = holdRotation;

            feather.GetComponent<Rigidbody>().useGravity = false;
            feather.GetComponent<Rigidbody>().isKinematic = true;
        }

        else if (obj.tag == "ukulele")
        {
            hasUk = true;
            ukulele = obj;

            ukulele.transform.parent = transform;

            ukulele.transform.localPosition = holdPosition;
            ukulele.transform.localEulerAngles = holdRotation;

            ukulele.GetComponent<Rigidbody>().useGravity = false;
            ukulele.GetComponent<Rigidbody>().isKinematic = true;
        }
    }

    void releaseFeather()
    {
        hasFeather = false;

        feather.transform.parent = null;

        Rigidbody rigidbody = feather.GetComponent<Rigidbody>();

        rigidbody.useGravity = true;
        rigidbody.isKinematic = false;

        rigidbody.velocity = OVRInput.GetLocalControllerVelocity(controller);

        rigidbody.velocity = OVRInput.GetLocalControllerVelocity(controller);

        hasFeather = false;
        feather = null;
    }

    void updateScroll()
    {
        return;
    }

    void OnGUI()
    {
        if (hasUk == true)
        {
            GUI.Box(new Rect(140, Screen.height - 50, Screen.width - 300, 120), ("Press B to play"));
        }
    }
}
