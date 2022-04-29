using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngelCarpmaCont : MonoBehaviour
{
    public Transform respawnPoint;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Engel")
        {
            this.gameObject.transform.position = respawnPoint.transform.position;
            Debug.Log("col");
        } 
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Engel")
        {
            this.gameObject.transform.position = respawnPoint.transform.position;
            Debug.Log("trig");

        }
    }
}
