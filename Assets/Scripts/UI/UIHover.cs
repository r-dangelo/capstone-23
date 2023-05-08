using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private GameObject hoverObject;
    [SerializeField] private GameObject hoverText;

    public void OnPointerEnter(PointerEventData eventData)
    {
        //if(hoverObject != null)
          //  hoverObject.SetActive(true);
        if (hoverText != null)
            hoverText.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //if (hoverObject != null)
          //  hoverObject.SetActive(false);
        if (hoverText != null)
            hoverText.SetActive(false);
    }

}
