using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowEvent : MonoBehaviour
{
    public GameObject hanna;
    public GameObject message;
    private SpriteRenderer hannaSprite;

    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        hannaSprite = hanna.GetComponent<SpriteRenderer>();
        hanna.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("SPACE");
            audio.Play();
            hanna.SetActive(true);
            StartCoroutine(FadeIn());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Lantern")
        {
            audio.Play();
            hanna.SetActive(true);
            StartCoroutine(FadeIn());
        }
    }

    IEnumerator FadeIn()
    {
        hannaSprite.color = Color.white;
        for (int i = 0; i < 20; i++)
        {
            yield return null;
        }

        float ElapsedTime = 0.0f;
        float TotalTime = 1f;

        while (ElapsedTime < TotalTime)
        {
            ElapsedTime += Time.deltaTime;
            hannaSprite.color = Color.Lerp(Color.white, Color.black, (ElapsedTime / TotalTime));
            yield return null;
        }

        hanna.SetActive(false);
        message.SetActive(true);

    }
}
