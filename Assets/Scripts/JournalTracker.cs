using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    [Header("UI Bars Inner")]
    [SerializeField] Image img_anamalia;
    [SerializeField] Image img_fungi;
    [SerializeField] Image img_chordata;
    [SerializeField] Image img_arthropada;
    [SerializeField] Image img_reptilia;
    [SerializeField] Image img_mamalia;
    [SerializeField] Image img_arachnida;
    [SerializeField] Image img_malacostraca;
    [SerializeField] Image img_decapoda;
    [SerializeField] Image img_carnivora;

    public void addKingdom(float amount, int kingdomSeeEnum)
    {
        switch (kingdomSeeEnum) {
            case 0:
                anamalia += amount;
                img_anamalia.fillAmount = anamalia;
                break;
            case 1:
                fungi += amount;
                img_fungi.fillAmount = fungi;
                break;
        }
    }

    public void addPhylum(float amount, int phylumSeeEnum)
    {
        switch(phylumSeeEnum) {
            case 0:
                chordata += amount;
                img_chordata.fillAmount = chordata;
                break;
            case 1:
                arthropoda += amount;
                img_arthropada.fillAmount = arthropoda;
                break;
        }
    }

    public void addClass(float amount, int classSeeEnum)
    {
        switch(classSeeEnum) {
            case 0:
                reptilia += amount;
                img_reptilia.fillAmount = reptilia;
                break;
            case 1:
                mammalia += amount;
                img_mamalia.fillAmount = mammalia;
                break;
            case 2:
                arachnida += amount;
                img_arachnida.fillAmount = arachnida;
                break;
            case 3:
                malacostraca += amount;
                img_malacostraca.fillAmount = malacostraca;
                break;
        }
    }

    public void addOrder(float amount, int orderSeeEnum)
    {
        switch (orderSeeEnum) {
            case 0:
                decapoda += amount;
                img_decapoda.fillAmount = decapoda;
                break;
            case 1:
                carnivora += amount;
                img_carnivora.fillAmount = carnivora;
                break;
        }
    }
}