using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Blur : MonoBehaviour
{
    public void startBlur()
    {
        Color temp = this.GetComponent<Image>().color;
        temp.a = Random.Range(.3f, .9f);
        this.GetComponent<Image>().color = temp;
    }

    // Completely Transparent = clear image
    // 
    public void changeBlur()
    {
        Color temp = this.GetComponent<Image>().color;
        temp.a -= 0.1f;
        this.GetComponent<Image>().color = temp;
    }
}
