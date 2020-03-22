using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{
  
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            pickup(other);
            
        }
    }

    void pickup(Collider2D player)
    {

        player.gameObject.GetComponent<health>().healths++;
        Destroy(gameObject);
    }
}
