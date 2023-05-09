using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    [Header("Things She Says")]
    [SerializeField] string[] mainThings;
    [SerializeField] string[] microscopeThings;
    [SerializeField] string[] soundThings;
    [SerializeField] string[] xrayThings;

    [Header("Textboxes")]
    [SerializeField] TextMeshProUGUI mainDialog;
    [SerializeField] TextMeshProUGUI microDialogue;
    [SerializeField] TextMeshProUGUI soundDialogue;
    [SerializeField] TextMeshProUGUI xrayDialog;

    public void playNextDialogue()
    {

    }

}
