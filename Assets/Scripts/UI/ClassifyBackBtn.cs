using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClassifyBackBtn : MonoBehaviour
{
    [SerializeField] public GameObject backBtn;

    private GameObject prevTog;

    public void SetAsPrevToggle(GameObject previous)
    {
        prevTog = previous;
    }

    public GameObject GetPreviousToggle()
    {
        return prevTog;
    }

    public void MoveBackBtn(GameObject newPos)
    {
        backBtn.transform.position = new Vector3(backBtn.transform.position.x,newPos.transform.position.y, backBtn.transform.position.z);

    }

    public void PressBackBtn()
    {
        MoveBackBtn(prevTog);
        prevTog.GetComponent<Toggle>().isOn = true;
    }

}
