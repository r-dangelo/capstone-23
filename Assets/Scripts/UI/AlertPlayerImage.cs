using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class AlertPlayerImage : MonoBehaviour
{
    [SerializeField] Color32 flashColor;
    public void flash()
    {
        this.GetComponent<Image>().color = flashColor;
    }
}
