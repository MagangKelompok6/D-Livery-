using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endCamera : MonoBehaviour
{
   
    public bool over;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.GetComponent<health>().healths -= other.gameObject.GetComponent<health>().healths;
        }
    }

    void Start()
    {
        over = false;
    }
}

