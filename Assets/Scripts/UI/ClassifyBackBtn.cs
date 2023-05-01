using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClassifyBackBtn : MonoBehaviour
{

    private GameObject prevTog;
    private GameObject closeTog;

    public void SetAsPrevToggle(GameObject previous)
    {
        prevTog = previous;
    }

    public GameObject GetPreviousToggle()
    {
        return prevTog;
    }

    public void SetCloseTog(GameObject togToClose)
    {
        closeTog = togToClose;
    }

    public void MoveBackBtn(GameObject newPos)
    {
        this.transform.position = new Vector3(this.transform.position.x,newPos.transform.position.y, this.transform.position.z);

    }

    public void PressBackBtn()
    {
        //MoveBackBtn(prevTog);
        //prevTog.GetComponent<ClassifyNav>().ProgressClassification();
        closeTog.GetComponent<ClassifyNav>().CloseNextBranch();

    }

}
