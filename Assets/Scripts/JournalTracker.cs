using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JournalTracker : MonoBehaviour
{
    [HideInInspector]
    public float anamalia = 0f;
    [HideInInspector]
    public float fungi = 0f;

    [HideInInspector]
    public float chordata = 0f;
    [HideInInspector]
    public float arthropoda = 0f;

    [HideInInspector]
    public float reptilia = 0f;
    [HideInInspector]
    public float mammalia = 0f;
    [HideInInspector]
    public float arachnida = 0f;
    [HideInInspector]
    public float malacostraca = 0f;

    [HideInInspector]
    public float decapoda = 0f;
    [HideInInspector]
    public float carnivora = 0f;

    public void addKingdom(float amount, int kingdomSeeEnum)
    {
        switch (kingdomSeeEnum) {
            case 0:
                anamalia += amount;
                break;
            case 1:
                fungi += amount;
                break;
        }
    }

    public void addPhylum(float amount, int phylumSeeEnum)
    {
        switch(phylumSeeEnum) {
            case 0:
                chordata += amount;
                break;
            case 1:
                arthropoda += amount;
                break;
        }
    }

    public void addClass(float amount, int classSeeEnum)
    {
        switch(classSeeEnum) {
            case 0:
                reptilia += amount;
                break;
            case 1:
                mammalia += amount;
                break;
            case 2:
                arachnida += amount;
                break;
            case 3:
                malacostraca += amount;
                break;
        }
    }

    public void addOrder(float amount, int orderSeeEnum)
    {
        switch (orderSeeEnum) {
            case 0:
                decapoda += amount;
                break;
            case 1:
                carnivora += amount;
                break;
        }
    }
}