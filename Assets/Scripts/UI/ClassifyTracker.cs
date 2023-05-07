using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClassifyTracker : MonoBehaviour
{
    protected string currentKing = "", currentPhy = "", currentClass = "", currentOrd = "";

    [SerializeField] public GameObject kingdomPanel, phylumPanel, classPanel, orderPanel;
    [SerializeField] public Toggle kingdomTog, phylumTog, classTog, orderTog;
    [SerializeField] public List<GameObject> kingdoms, phylums, classes, orders;
    [SerializeField] public GameObject classifyBtn;

    public void SetCurrentKingdom(string curKing)
    {
        currentKing = curKing;
    }

    public void SetCurrentPhylum(string curPhy)
    {
        currentPhy = curPhy;
    }

    public void SetCurrentClass(string curClass)
    {
        currentClass = curClass;
    }

    public void SetCurrentOrder(string curOrd)
    {
        currentOrd = curOrd;
    }

    public void RefreshTree()
    {
        if(kingdomTog.isOn)
        {
            if (currentKing.ToString().Equals("animalia"))
            {
                phylumTog.isOn = true;
                phylums[0].SetActive(true);
                //phylums[0].GetComponent<OpenDataTween>().OpenChildren();
            }

            if (currentKing.ToString().Equals("fungi"))
            {
                phylumTog.isOn = true;
                phylums[1].SetActive(true);
                //phylums[1].GetComponent<OpenDataTween>().OpenChildren();
            }
        }
        else if(phylumTog.isOn)
        {
            if (currentPhy.ToString().Equals("chordata"))
            {
                classTog.isOn = true;
                classes[0].SetActive(true);
                //classes[0].GetComponent<OpenDataTween>().OpenChildren();
            }

            if (currentPhy.ToString().Equals("arthropoda"))
            {
                classTog.isOn = true;
                classes[1].SetActive(true);
                //classes[1].GetComponent<OpenDataTween>().OpenChildren();
            }

            if (currentPhy.ToString().Equals("fungus"))
            {
                classTog.isOn = true;
                classes[2].SetActive(true);
                //classes[2].GetComponent<OpenDataTween>().OpenChildren();
            }

        }

        else if(classTog.isOn)
        {
            if (currentClass.ToString().Equals("mammalia"))
            {
                orderTog.isOn = true;
                orders[0].SetActive(true);
            }
            if (currentClass.ToString().Equals("reptilia"))
            {
                orderTog.isOn = true;
                orders[1].SetActive(true);
            }

            if (currentClass.ToString().Equals("arachnida"))
            {
                orderTog.isOn = true;
                orders[2].SetActive(true);
            }
            if (currentClass.ToString().Equals("crusty"))
            {
                orderTog.isOn = true;
                orders[3].SetActive(true);
            }

            if (currentClass.ToString().Equals("fungi"))
            {
                orderTog.isOn = true;
                orders[4].SetActive(true);
            }
        }

        else if(orderTog.isOn)
        {
            classifyBtn.SetActive(true);
            classifyBtn.GetComponent<Button>().interactable = true;
        }
        /*
        if (classTog.isOn && currentClass.ToString().Equals("cat"))
        {
            classTog.isOn = true;
            classes[0].SetActive(true);
        }
        */
    }

}
