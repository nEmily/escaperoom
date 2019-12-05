using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollOpener : MonoBehaviour
{
    public GameObject content; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) {
            if (content.activeSelf) {
                Close();
            } else {
                Open();
            }
        }
    }

    public void Open()
    {
        content.SetActive(true);
    }

    public void Close()
    {
        content.SetActive(false);
    }
}
