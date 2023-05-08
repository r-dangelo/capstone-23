using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBarsAnim : MonoBehaviour
{
    [SerializeField] public GameObject parentObj;
    private IEnumerator running;

    public void Awake()
    {
        if (parentObj.activeSelf && running == null)
            RandomHeight();
        else if(!parentObj.activeSelf && running != null)
            running = null;
    }

    public void RandomHeight()
    {
        float height = Random.Range(.3f,1);
        LeanTween.scaleY(this.gameObject, height, height / 2);
        LeanTween.scaleY(this.gameObject, 0, height / 2).setDelay(height / 2);
        running = WaitForAnim(height);
        StartCoroutine(running);
        
    }

    public IEnumerator WaitForAnim(float duration)
    {
        yield return new WaitForSeconds(duration);
        RandomHeight();
        //running = null;
    }

}
