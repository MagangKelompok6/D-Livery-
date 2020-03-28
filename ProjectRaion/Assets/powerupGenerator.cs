using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupGenerator : MonoBehaviour
{
    [SerializeField] private GameObject scoreGenerator;
    [SerializeField] private GameObject powerUp;
    [SerializeField] private GameObject generator;
    [SerializeField] private GameObject player;
    private int currentScore;
    private int currentHealth;
    Vector3 lastEndPosition;
    public bool powerupBool=false;
   
    void Update()
    {
        currentHealth = player.GetComponent<health>().healths;
        currentScore = System.Convert.ToInt32(scoreGenerator.GetComponent<scoring>().jumlah) % 10;
        lastEndPosition = generator.GetComponent<lvl>().lastEndPosition;
        lastEndPosition.y += 9;
        if (currentScore==0 && powerupBool==false && currentHealth < 2)
        {
            spawn(powerUp,lastEndPosition);
            powerupBool=true;
        }
        Debug.Log(currentScore);
        Debug.Log(powerupBool);
    }
    void spawn(GameObject powerup, Vector3 lastEnd)
    {
        Instantiate(powerup,lastEnd,Quaternion.identity);
    }
}
