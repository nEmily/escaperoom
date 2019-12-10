using System.Collections;
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
    private GameObject holding;

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

        if (hasUk)
        {
            //display text, "Press to play"
            if (Input.GetButtonDown("Space"))
            {
                ukuleleSound.Play(0);
            }
        }

        if (handTriggerState < 0.6f) {
            if (hasFeather){
             hasFeather = false   
        }
        else if (hasUk){
            hasUk = false
        }
            release()
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
                hasFeather = true;
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
                hasUk = true;
                print("Grabbing ukulele.");
                Grab(ukulele);
            }
        }
        else {
            Grab(other.gameObject);
        }
    }

    void Grab(GameObject obj)
    {
            obj.transform.parent = transform;
            obj.transform.localPosition = holdPosition;
            obj.transform.localEulerAngles = holdRotation;
            obj.GetComponent<Rigidbody>().useGravity = false;
            obj.GetComponent<Rigidbody>().isKinematic = true;
            holding = obj
    }

    void release()
    {
        holding.transform.parent = null;

        Rigidbody rigidbody = holding.GetComponent<Rigidbody>();

        rigidbody.useGravity = true;
        rigidbody.isKinematic = false;

        rigidbody.velocity = OVRInput.GetLocalControllerVelocity(controller);

        rigidbody.velocity = OVRInput.GetLocalControllerVelocity(controller);
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
