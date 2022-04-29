using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcFinishController : MonoBehaviour
{
    public GameObject losePanel;
    public GameObject player;
    public GameObject nPCS;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="NPC")
        {
            losePanel.SetActive(true);
            Destroy(player);
            Destroy(nPCS);
        }
    }
}
