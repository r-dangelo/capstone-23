using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleSoundAnim : MonoBehaviour
{
    [SerializeField] GameObject animParent;

    private void Awake()
    {
        animParent.SetActive(false);
    }

    public void StartAnims()
    {
        StartCoroutine(WaitForSound(this.GetComponent<playSound>().GetSoundLength()));
        for (int i=0;i<animParent.transform.childCount; i++)
        {
            animParent.transform.GetChild(i).GetComponent<SoundBarsAnim>().RandomHeight();
        }

    }

    public IEnumerator WaitForSound(float duration)
    {
        animParent.SetActive(true);
        this.gameObject.GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(duration);
        animParent.SetActive(false);
        this.gameObject.GetComponent<Button>().interactable = true;
    }

}
