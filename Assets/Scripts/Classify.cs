using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Classify : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] GameObject endPanel;
    kingdoms kingdom;
    phylums phylum;
    classes clas;
    orders order;

    public void setKingdom(int newKing)
    {
        kingdom = (kingdoms)newKing;
    }

    public void setPhylum(int newPhy)
    {
        phylum = (phylums)newPhy;
    }

    public void setClass(int newClas)
    {
        clas = (classes)newClas;
    }

    public void setOrder(int newWorldOrder)
    {
        order = (orders)newWorldOrder;
    }

    public void checkAnswers()
    {
        Taxa checker = gameObject.GetComponent<MainController>().currentCreature.taxa;
        int score = 0;

        if (checker.kingdom == kingdom) { score += 1; }
        if (checker.phylum == phylum) { score += 1; }
        if (checker.classs == clas) { score += 1; }
        if (checker.order == order) { score += 1; }

        gameObject.GetComponent<MainController>().score = score;
        endPanel.SetActive(true);
        scoreText.SetText("You got " + score + "/4 correct.\n" + "The correct answers were:\n" +
                           checker.kingdom + " " + checker.phylum + " " + checker.classs + " " + checker.order + ".");
    }
}