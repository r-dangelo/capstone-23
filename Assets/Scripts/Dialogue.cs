using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    [SerializeField] GameObject JunPanel;

    [Header("Things She Says")]
    [SerializeField] string[] introThings;
    [SerializeField] string[] randomThings;

    [Header("Textboxes")]
    [SerializeField] TextMeshProUGUI mainDialog;
    [SerializeField] TextMeshProUGUI microDialogue;
    [SerializeField] TextMeshProUGUI soundDialogue;
    [SerializeField] TextMeshProUGUI xrayDialog;
    [SerializeField] TextMeshProUGUI xrayLeftDia;
    [SerializeField] TextMeshProUGUI sampleLeftDia;

    int mainIndex = 0;
    bool introComplete = false;

    public void playMain()
    {
        if (!introComplete) {
            if (mainIndex >= 2) {
                introComplete = true;
                mainDialog.transform.parent.gameObject.SetActive(false);
                JunPanel.SetActive(true);
                mainDialog.text = randomThings[Random.Range(0, randomThings.Length)];
            }
            mainDialog.text = introThings[mainIndex];
            mainIndex++;
        }
        else {
            JunPanel.SetActive(true);
            mainDialog.transform.parent.gameObject.SetActive(false);
        }
    }

    public void playRandom()
    {
        mainDialog.text = randomThings[Random.Range(0, randomThings.Length)];
    }

    public void setMicroDialogue(string dialogue)
    {
        microDialogue.text = dialogue;
    }

    public void setSoundDialogue(string dialog)
    {
        soundDialogue.text = dialog;
    }

    public void setXRayDialogue(string dialogue)
    {
        xrayDialog.text = dialogue;
    }

    public void setXRayLeftGuide(string dialogue)
    {
        xrayLeftDia.text += dialogue + "\n \n";
    }

    public void setMicroLeftDia(string dialogue)
    {
        sampleLeftDia.text += dialogue + "\n \n";
    }
}
