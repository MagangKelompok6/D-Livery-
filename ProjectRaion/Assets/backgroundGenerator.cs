using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundGenerator : MonoBehaviour
{
    private const float playerDistance = 100f;
    [SerializeField] private Transform backgroundStart;
    [SerializeField] private Transform background;
    [SerializeField] private GameObject player;
    private Vector3 lastEndPosition;
    void Awake()
    {
        lastEndPosition = backgroundStart.Find("EndPosition").position;
        spawn();
    }
    

    
    void Update()
    {
        if (Vector3.Distance(player.transform.position, lastEndPosition) < playerDistance)
        {
            spawn();
            
        }
    }
    void spawn()
    {
        Transform lastLvlPart = SpawnLvl(background, lastEndPosition);
        lastEndPosition = lastLvlPart.Find("EndPosition").position;
    }
    Transform SpawnLvl(Transform lvlPr, Vector3 spawnPosition)
    {
        Transform lvlPart = Instantiate(lvlPr, spawnPosition, Quaternion.identity);
        return lvlPart;
    }
}
