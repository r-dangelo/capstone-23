using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkAnim : MonoBehaviour
{
    [SerializeField] public float growAmnt;
    [SerializeField] public float duration;

    public void ShrinkAnimation()
    {
        LeanTween.scaleX(this.gameObject, growAmnt, duration * .2f).setEaseOutQuart();
        LeanTween.scaleY(this.gameObject, growAmnt, duration * .2f).setEaseOutQuart();
        LeanTween.scaleX(this.gameObject, 0, duration * .8f).setEaseOutBounce().setDelay(duration*.2f);
        LeanTween.scaleY(this.gameObject, 0, duration * .8f).setEaseOutBounce().setDelay(duration*.2f);
        StartCoroutine(WaitForAnim(duration));

    }

    public IEnumerator WaitForAnim(float dur)
    {
        yield return new WaitForSeconds(dur);
        this.gameObject.SetActive(false);
    }

}
