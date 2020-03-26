using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zeroHealth : MonoBehaviour
{
   public bool over;

    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            other.gameObject.GetComponent<health>().healths = 0;
        }
    }
    
    void Start() {
        over = false;
    }
}
