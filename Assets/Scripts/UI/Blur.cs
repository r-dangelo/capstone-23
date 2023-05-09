using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Blur : MonoBehaviour
{
    [SerializeField] Slider slider;
    float targetBlurVal = 0;

    private void Start()
    {
        targetBlurVal = Random.Range(.3f, .9f);
    }

    public void changeBlur()
    {
        float difference = Mathf.Abs(slider.value - targetBlurVal);
        Color temp = this.GetComponent<Image>().color;
        temp.a = difference;
        this.GetComponent<Image>().color = temp;
    }
}
