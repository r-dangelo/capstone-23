using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundTestInput : MonoBehaviour
{
    [Header("Toggles")]
    [SerializeField] Toggle slr1_neg;
    [SerializeField] Toggle slr1_neu;
    [SerializeField] Toggle slr1_pos;
    [SerializeField] Toggle slr2_neg;
    [SerializeField] Toggle slr2_neu;
    [SerializeField] Toggle slr2_pos;
    public bool slrLow_bad { get; set; } = false;
    public bool slrLow_neutral { get; set; } = false;
    public bool slrLow_positive { get; set; } = false;
    public bool slrHigh_bad { get; set; } = false;
    public bool slrHigh_neutral { get; set; } = false;
    public bool slrHigh_positive { get; set; } = false;

    CreatureController currentCreature;
    JournalTracker journal;

    private void Start()
    {
        currentCreature = gameObject.GetComponent<MainController>().currentCreature;
        journal = gameObject.GetComponent<JournalTracker>();
    }

    public void updateSlr()
    {
        slrLow_bad = slr2_neg.isOn;
        slrLow_neutral = slr2_neu.isOn;
        slrLow_positive = slr2_pos.isOn;

        slrHigh_bad = slr1_neg.isOn;
        slrHigh_neutral = slr1_neu.isOn;
        slrHigh_positive = slr1_pos.isOn;
    }

    public void collectInput()
    {
        switch (currentCreature.soundTest.frequency1Reaction) {
            case soundReactions.Positive:
                if (slrLow_positive) {
                    journal.addOrder(2);
                }
                else {
                    journal.addOrder(1);
                }
                break;
            case soundReactions.None:
                if(slrLow_neutral) {
                    journal.addOrder(1);
                }
                else {
                    journal.addPhylum(1);
                }
                break;
            case soundReactions.Negative:
                if(slrLow_bad) {
                    journal.addOrder(0);
                }
                else {
                    journal.addKingdom(1);
                }
                break;
        }

        switch (currentCreature.soundTest.frequency2Reaction) {
            case soundReactions.Positive:
                if (slrLow_positive) {
                    journal.addClass(1);
                }
                else {
                    journal.addOrder(2);
                }
                break;
            case soundReactions.None:
                if (slrLow_neutral) {
                    journal.addKingdom(1);
                }
                else {
                    journal.addOrder(2);
                }
                break;
            case soundReactions.Negative:
                if (slrLow_bad) {
                    journal.addOrder(0);
                }
                else {
                    journal.addOrder(1);
                }
                break;
        }
    }
}
