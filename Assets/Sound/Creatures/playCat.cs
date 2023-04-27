using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playCat : MonoBehaviour
{
    public AudioSource soundCat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playThisCat()
    {
        soundCat.Play();
    }
}
