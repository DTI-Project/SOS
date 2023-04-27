using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class interativeNpc : MonoBehaviour
{
    Transform player;
    public float interactDistance;
    public String[] list;
    public TextMeshProUGUI dialougeText;
    public float timeInterval;


    bool converstionStarted;
    bool converstionFinished;
    bool done = false;
    int curr;

    private void Start()
    {
        player = FindObjectOfType<FirstPersonController>().transform;
        dialougeText.gameObject.SetActive(false);
        converstionStarted = false;
        converstionFinished = false;
        curr = 0;
        done = false;
        //Debug.Log(list.Length);
    }

    private void Update()
    {
        if (!converstionStarted && (transform.position-player.position).magnitude <= interactDistance)
        {
            dialougeText.gameObject.SetActive(true);
            converstionStarted = true;
            //player.LookAt(transform.position);
        }

        if (!done && converstionStarted)
        {
            changeText();
            done = true;
        }

        if((transform.position - player.position).magnitude > interactDistance)
        {
            reset();
        }

    }

    void reset()
    {
        converstionStarted = false;
        converstionFinished = false;
        curr = 0;
        done = false;
    }

    void changeText()
    {
        //Debug.Log(curr);
        if (curr == list.Length)
        {
            dialougeText.gameObject.SetActive(false);
        }
        if (curr < list.Length)
        {
            dialougeText.SetText(list[curr]);
            curr += 1;
            Invoke("changeText", timeInterval * curr);
        }

        

    }

}
