using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl : MonoBehaviour
{
    private const float playerDistance = 100f;
    [SerializeField] private Transform startLvl;
    [SerializeField] private Transform lvl1;
    [SerializeField] private Transform lvl2;
    [SerializeField] private Transform lvl3;
    [SerializeField] private Transform lvl4;
    [SerializeField] private Transform lvl5;
    [SerializeField] private GameObject player;
    private Vector3 lastEndPosition;
    void Awake()
    {
        lastEndPosition = startLvl.Find("EndPosition").position;
        spawn();
    }
    private void Update()
    {

        if (Vector3.Distance(player.transform.position, lastEndPosition) < playerDistance)
        {
            spawn();
        }

    }
    void spawn()
    {
        Transform[] listLvl = { lvl1, lvl2, lvl3, lvl4, lvl5 };
        Transform randomPart = listLvl[Random.Range(0, listLvl.Length)];
        Transform lastLvlPart = SpawnLvl(randomPart, lastEndPosition);
        lastEndPosition = lastLvlPart.Find("EndPosition").position;
    }
    Transform SpawnLvl(Transform lvlPr, Vector3 spawnPosition)
    {
        Transform lvlPart = Instantiate(lvlPr, spawnPosition, Quaternion.identity);
        return lvlPart;
    }
}
