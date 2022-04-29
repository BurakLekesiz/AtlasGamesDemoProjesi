using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public Transform respawnPosition;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Player"||collision.gameObject.tag=="NPC")
        {
            collision.gameObject.transform.position = respawnPosition.transform.position;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "NPC")
        {
            other.gameObject.transform.position = respawnPosition.transform.position;
        }
    }
}
