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
        hoverObject.SetActive(true);
        hoverText.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        hoverObject.SetActive(false);
        hoverText.SetActive(false);
    }
}
