using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClassifyTracker : MonoBehaviour
{
    protected string currentKing = "", currentPhy = "", currentClass = "", currentOrd = "";
    public Toggle thisTog;

    [SerializeField] public GameObject kingdomPanel, phylumPanel, classPanel, orderPanel;
    [SerializeField] public Toggle kingdomTog, phylumTog, classTog, orderTog;
    [SerializeField] public List<GameObject> kingdoms, phylums, classes, orders;
    [SerializeField] public GameObject classifyBtn;

    public void Start()
    {
        currentKing = "";
        currentPhy = "";
        currentClass = "";
        currentOrd = "";

    }

    public void SetThisTog(Toggle curTog)
    {
        thisTog = curTog;
    }

    public void SetCurrentKingdom(string curKing)
    {
        if (thisTog.isOn)
        {
            currentKing = curKing;
            RefreshTree();
            //Debug.Log("set king");
        }
        else
            currentKing = "";
    }

    public void SetCurrentPhylum(string curPhy)
    {
        if (thisTog.isOn)
        {
            currentPhy = curPhy;
            RefreshTree();
            //Debug.Log("set phy");
        }
        else
            currentPhy = "";
    }

    public void SetCurrentClass(string curClass)
    {
        if (thisTog.isOn)
        {
            currentClass = curClass;
            RefreshTree();
            //Debug.Log("set class");
        }
        else
            currentClass = "";
    }

    public void SetCurrentOrder(string curOrd)
    {
        if (thisTog.isOn)
        {
            currentOrd = curOrd;
            RefreshTree();
            //Debug.Log("set order");
        }
        else
            currentOrd = "";

    }

    public void RefreshTree()
    {
        //classifyBtn.SetActive(false);
        //Debug.Log("refresh");
        if(kingdomTog.isOn)
        {
            //Debug.Log("kingdom on");
            if (currentKing.ToString().Equals("animalia"))
            {
                
                phylums[0].SetActive(true);
                phylums[1].SetActive(false);
                phylumTog.isOn = true;
                //Debug.Log("animalia");
            }

            if (currentKing.ToString().Equals("fungi"))
            {
                
                phylums[1].SetActive(true);
                phylums[0].SetActive(false);
                phylumTog.isOn = true;
                //Debug.Log("king fungi");
            }
        }
        else if(phylumTog.isOn)
        {
            if (currentPhy.ToString().Equals("chordata"))
            {
                
                classes[0].SetActive(true);
                classes[1].SetActive(false);
                classes[2].SetActive(false);
                classTog.isOn = true;
                //Debug.Log("chordata");
            }

            if (currentPhy.ToString().Equals("arthropoda"))
            {
                classes[1].SetActive(true);
                classes[0].SetActive(false);
                classes[2].SetActive(false);
                classTog.isOn = true;
                //Debug.Log("arthropoda");
            }

            if (currentPhy.ToString().Equals("fungus"))
            {
                classes[2].SetActive(true);
                classes[0].SetActive(false);
                classes[1].SetActive(false);
                classTog.isOn = true;
                //Debug.Log("phy fungus");
            }

        }

        else if(classTog.isOn)
        {
            if (currentClass.ToString().Equals("mammalia"))
            {
                orderTog.isOn = true;
                orders[0].SetActive(true);
                orders[1].SetActive(false);
                orders[2].SetActive(false);
                orders[3].SetActive(false);
                orders[4].SetActive(false);
                //Debug.Log("mammalia");
            }
            if (currentClass.ToString().Equals("reptilia"))
            {
                orderTog.isOn = true;
                orders[1].SetActive(true);
                orders[0].SetActive(false);
                orders[2].SetActive(false);
                orders[3].SetActive(false);
                orders[4].SetActive(false);
                //Debug.Log("reptilia");
            }

            if (currentClass.ToString().Equals("arachnida"))
            {
                orderTog.isOn = true;
                orders[2].SetActive(true);
                orders[1].SetActive(false);
                orders[0].SetActive(false);
                orders[3].SetActive(false);
                orders[4].SetActive(false);
                //Debug.Log("arachnida");
            }
            if (currentClass.ToString().Equals("crusty"))
            {
                orderTog.isOn = true;
                orders[3].SetActive(true);
                orders[1].SetActive(false);
                orders[2].SetActive(false);
                orders[0].SetActive(false);
                orders[4].SetActive(false);
                //Debug.Log("crusty");
            }

            if (currentClass.ToString().Equals("fungi"))
            {
                orderTog.isOn = true;
                orders[4].SetActive(true);
                orders[1].SetActive(false);
                orders[2].SetActive(false);
                orders[3].SetActive(false);
                orders[0].SetActive(false);
                //Debug.Log("class fungi");
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
