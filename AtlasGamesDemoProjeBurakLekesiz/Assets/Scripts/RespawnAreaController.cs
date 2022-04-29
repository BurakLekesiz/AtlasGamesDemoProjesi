using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnAreaController : MonoBehaviour
{
    public Transform respawnPoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player"|| other.gameObject.tag=="NPC")
        {
            other.gameObject.transform.position = respawnPoint.transform.position;
        }
    }
    
}
