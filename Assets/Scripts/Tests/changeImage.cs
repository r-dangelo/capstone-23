using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeImage : MonoBehaviour
{
    List<Image> imagesToChange;

    private void Start()
    {
        GameObject[] images = GameObject.FindGameObjectsWithTag("");
        foreach(GameObject image in images)
        {
            if (image.gameObject.GetComponent<Image>())
            {
                imagesToChange.Add(image.gameObject.GetComponent<Image>());
            }
        }
    }


}