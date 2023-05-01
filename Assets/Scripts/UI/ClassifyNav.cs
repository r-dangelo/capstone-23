using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UIElements;
using UnityEngine.UI;

public class ClassifyNav : MonoBehaviour
{
    [SerializeField] public ClassifyBackBtn backBtnScript;
    [SerializeField] public GameObject parentTog;
    [SerializeField] public GameObject nextTog;
    [SerializeField] public GameObject nextPanel;
    [SerializeField] public GameObject nextTaxa;
    [SerializeField] public List<GameObject> otherTaxa;

    public void ProgressClassification()
    {
        if(parentTog != null)
            backBtnScript.SetAsPrevToggle(parentTog.gameObject);

        if (otherTaxa != null)
        {
            for (int i = 0; i < otherTaxa.Count; i++)
                otherTaxa[i].SetActive(false);
        }
        
        if(nextTaxa != null)
            nextTaxa.SetActive(true);
        if (nextPanel != null)
            nextPanel.GetComponent<OpenDataTween>().Open();
        if (nextTaxa != null)
            for (int i=0;i<nextTaxa.transform.childCount;i++)
                if(nextTaxa.transform.GetChild(i).gameObject.activeSelf)
                    nextTaxa.transform.GetChild(i).GetComponent<OpenDataTween>().Open();

        if (nextTog != null)
          backBtnScript.MoveBackBtn(nextTog);

    }

    public void CloseNextBranch()
    {
        if (nextPanel != null)
            nextPanel.GetComponent<OpenDataTween>().Close();
        if (otherTaxa != null)
            for (int i = 0; i < otherTaxa.Count; i++)
                if (otherTaxa[i].gameObject.activeSelf)
                    for (int x = 0; x<otherTaxa[i].transform.childCount; x++)
                        if(otherTaxa[i].transform.GetChild(x).gameObject.activeSelf)
                            otherTaxa[i].transform.GetChild(x).GetComponent<OpenDataTween>().Close();

    }


}
