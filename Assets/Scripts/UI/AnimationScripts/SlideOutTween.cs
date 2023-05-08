using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideOutTween : MonoBehaviour
{
    [SerializeField] public Toggle tog;
    [SerializeField] public float xDistOut;
    [SerializeField] public float xDistIn;
    [SerializeField] public float duration;

    public void MovePanel()
    {
        if (tog.isOn)
            SlidePanelOut();
        else if (!tog.isOn)
            SlidePanelIn();
    }

    public void SlidePanelOut()
    {
        LeanTween.moveX(this.gameObject, xDistOut, duration).setEaseInOutQuart();
        StartCoroutine(WaitForAnim(duration));
    }
    
    public void SlidePanelIn()
    {
        //this.gameObject.SetActive(true);
        LeanTween.moveX(this.gameObject, xDistIn, duration).setEaseInOutQuart();
        //StartCoroutine(WaitForAnim(duration));
    }

    public IEnumerator WaitForAnim(float dur)
    {
        yield return new WaitForSeconds(dur);
        //this.gameObject.SetActive(false);
    }

}
