using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D;

public class DoItForHer : MonoBehaviour
{
    public bool isPossible = false;
    string word;
    [SerializeField] GameObject doItForHer;

    void Start()
    {
        
    }

    void Update()
    {
        if(isPossible) {
            word += keyPressed();
            if (Input.GetKeyDown(KeyCode.Return) && word == "doitforher") { 
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