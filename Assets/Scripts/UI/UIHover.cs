using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private GameObject hoverText;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (hoverText != null)
            hoverText.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (hoverText != null)
            hoverText.SetActive(false);
    }
}
