using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLoop : MonoBehaviour
{
    public GameObject platform;
    public GameObject prevplatform;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x>platform.transform.position.x)
        {
            var tempPlatform = prevplatform;
            prevplatform = platform;
            tempPlatform.transform.position += new Vector3(80,0,0);
            platform = tempPlatform;
        }
    }
}
