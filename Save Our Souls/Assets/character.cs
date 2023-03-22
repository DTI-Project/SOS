using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    public GameObject Info1;
    public GameObject TalkButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // protected override void Interact()
    // {
    //     Info1.SetActive(true);

    // }

    public void Talk()
    {
        Info1.SetActive(true);

        TalkButton.SetActive(false);

    }

}
