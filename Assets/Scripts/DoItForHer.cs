using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D;

public class DoItForHer : MonoBehaviour
{
    public bool isPossible = false;
    string word = "";
    [SerializeField] GameObject doItForHer;

    public void setPossibility(bool possibility)
    {
        isPossible = possibility;
    }


    void Update()
    {
        if(isPossible && Input.anyKeyDown) {
            word += keyPressed();
            print(word);

            if (Input.GetKeyDown(KeyCode.Tab)) {
                word = "";
            }
            if (word == "DOITFORHER") {
                doItForHer.SetActive(true);
            }
        }
    }

    KeyCode keyPressed()
    {
        foreach (KeyCode key in Enum.GetValues(typeof(KeyCode))) {
            if (Input.GetKeyDown(key)) {
                return key;
            }
        }
        return KeyCode.None;
    }
}