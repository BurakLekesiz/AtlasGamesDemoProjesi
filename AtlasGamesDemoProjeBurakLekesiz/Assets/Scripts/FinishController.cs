using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishController : MonoBehaviour
{
    public GameObject timeLine;
    public GameObject duvar;
    public GameObject winPanel;
    public GameObject nPCS;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="FinishCizgi")
        {
            timeLine.SetActive(true);
            nPCS.SetActive(false);
        }
        if (other.gameObject.tag=="Button")
        {
            duvar.gameObject.GetComponent<Renderer>().material.color = Color.red;
            StartCoroutine(Bekle(2f));
        }
       
    }

    IEnumerator Bekle(float zaman)
    {
        yield return new WaitForSeconds(zaman);
        winPanel.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
