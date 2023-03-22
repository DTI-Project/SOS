using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solider : MonoBehaviour
{
    public GameObject Info2;
    public GameObject TalkButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Talk()
    {
        Info2.SetActive(true);

        TalkButton.SetActive(false);

    }
}
