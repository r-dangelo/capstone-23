using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDataTween : MonoBehaviour
{
    [SerializeField] public GameObject content;

    [SerializeField] public float openWidth;
    [SerializeField] public float openHeight;

    [SerializeField] public float duration;
    [SerializeField] public float closeDuration;

    protected bool tog = false;

    public void SwitchTog()
    {
        tog = !tog;
    }

    public void Move()
    {
        if(this.gameObject.activeSelf)
        {
            SwitchTog();

            if (!tog)
                Close();
            else if (tog)
                Open();
        }

    }

    public void Open()
    {
        this.gameObject.SetActive(true);
        //LeanTween.moveX(this.gameObject, xDist, duration / 3);
        LeanTween.size(this.GetComponent<RectTransform>(), new Vector2(openWidth, 10), duration / 4).setEaseInOutQuint();
        LeanTween.size(this.GetComponent<RectTransform>(), new Vector2(openWidth, openHeight), duration / 3).setDelay(duration / 4).setEaseInOutCubic();
        if(content != null)
            LeanTween.scaleY(content, 1f, duration / 3).setDelay(duration / 3).setEaseInOutCubic();
    }

    public void Close()
    {
        LeanTween.size(this.GetComponent<RectTransform>(), new Vector2(openWidth, 10), closeDuration / 4).setEaseInOutCubic();
        LeanTween.size(this.GetComponent<RectTransform>(), new Vector2(0, 10), closeDuration / 3).setDelay(closeDuration / 4).setEaseInOutQuint();

        if (content != null)
            LeanTween.scaleY(content, 0f, duration / 3).setEaseInOutCubic();
        StartCoroutine(WaitForAnim(duration));
    }

    public void OpenChildren()
    {
        if(this.gameObject.activeSelf)
            for (int i = 0; i < this.transform.childCount; i++)
                if (this.transform.GetChild(i).gameObject.activeSelf)
                    this.transform.GetChild(i).GetComponent<OpenDataTween>().Open();
    }

    public void CloseChildren()
    {
        if (this.gameObject.activeSelf)
            for (int i = 0; i < this.transform.childCount; i++)
                if (this.transform.GetChild(i).gameObject.activeSelf)
                    this.transform.GetChild(i).GetComponent<OpenDataTween>().Close();
    }

    public void MoveChildren()
    {
        if (this.gameObject.activeSelf)
            for (int i = 0; i < this.transform.childCount; i++)
                if (this.transform.GetChild(i).gameObject.activeSelf)
                    this.transform.GetChild(i).GetComponent<OpenDataTween>().Move();
    }

    public IEnumerator WaitForAnim(float duration)
    {
        yield return new WaitForSeconds(duration);
        //this.gameObject.SetActive(false);
        //this.gameObject.transform.position = new Vector2(155,32);
        //LeanTween.size(this.GetComponent<RectTransform>(), new Vector2(210, 150), 0);
    }

}
