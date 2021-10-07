using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryCollision : MonoBehaviour
{
    public GameObject cam;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Destroy(other.gameObject);
        }
    }
}
