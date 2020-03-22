using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    
    public int healths;
    public Image[] hearts;

    void Update()
    {
        if(healths==0){
            Time.timeScale = 0;
        }
        for (int i = 0; i < 2; i++)
        {
            if (i<healths)
            {
                hearts[i].enabled = true;
            }else{
                hearts[i].enabled = false;
            }
        }    
    }
}
