using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{
    public AudioClip sound;
    AudioSource audio;
    private bool isPower;
    Renderer rend;

    void Start(){
        isPower = false;
        audio = GetComponent<AudioSource>();
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        isPower= true;
        if (other.CompareTag("Player"))
        {
            pickup(other);   
        }
    }

    void Update()
    {
        if(isPower==true){
            audio.PlayOneShot(sound,1f);
            rend.enabled = false;
            isPower = false;
        }
    }

    void pickup(Collider2D player)
    {
        if(player.gameObject.GetComponent<health>().healths>=2){
            player.gameObject.GetComponent<health>().healths=2;
        }else{
            player.gameObject.GetComponent<health>().healths++;
        }
    }
}
