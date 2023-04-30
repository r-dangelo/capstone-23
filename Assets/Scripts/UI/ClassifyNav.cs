using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UIElements;
using UnityEngine.UI;

public class ClassifyNav : MonoBehaviour
{
    [SerializeField] public ClassifyBackBtn backBtnScript;
    [SerializeField] public GameObject nextTog;
    [SerializeField] public GameObject nextPanel;
    [SerializeField] public GameObject nextTaxa;
    [SerializeField] public List<GameObject> otherTaxa;

    public void ProgressClassification()
    {
        //backBtnScript.SetAsPrevToggle(this.gameObject);

        if (otherTaxa != null)
        {
            for (int i = 0; i < otherTaxa.Count; i++)
                otherTaxa[i].SetActive(false);
        }
        
        if(nextTaxa != null)
            nextTaxa.SetActive(true);
        if (nextPanel != null)
            nextPanel.GetComponent<OpenDataTween>().Move();
        if (nextTaxa != null)
            for (int i=0;i<nextTaxa.transform.childCount;i++)
                nextTaxa.transform.GetChild(i).GetComponent<OpenDataTween>().Move();

        if (nextTog != null)
            backBtnScript.MoveBackBtn(nextTog);

    }


}
