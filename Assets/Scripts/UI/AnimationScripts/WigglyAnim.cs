using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WigglyAnim : MonoBehaviour
{
    [SerializeField] public float xScale;
    [SerializeField] public float yScale;
    [SerializeField] public float yDist;
    [SerializeField] public float duration;

    public void Awake()
    {
        Wiggle();
    }

    public void Wiggle()
    {
        LeanTween.scaleX(this.gameObject, xScale, duration).setEaseInOutQuart();
        if(yDist != 0)
            LeanTween.moveLocalY(this.gameObject, yDist, duration).setEaseInQuart();
        LeanTween.scaleY(this.gameObject, yScale, duration * .8f).setEaseInOutQuart().setDelay(duration * .2f);
        LeanTween.scaleX(this.gameObject, -1, duration*1.2f).setEaseInOutQuart().setDelay(duration*.8f);
        if (yDist != 0)
            LeanTween.moveLocalY(this.gameObject, -yDist, duration).setEaseOutQuart().setDelay(duration);
        LeanTween.scaleY(this.gameObject, 1, duration).setEaseInOutQuart().setDelay(duration);
        StartCoroutine(WaitForAnim(duration*1.8f));
    }

    public IEnumerator WaitForAnim(float dur)
    {
        yield return new WaitForSeconds(dur);
        Wiggle();
    }

}
