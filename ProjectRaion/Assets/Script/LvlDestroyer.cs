using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlDestroyer : MonoBehaviour
{
    private GameObject destroyer;

    private void Start()
    {
        destroyer = GameObject.Find("Destroyer");
    }

    void Update()
    {
        if (transform.position.x < destroyer.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
