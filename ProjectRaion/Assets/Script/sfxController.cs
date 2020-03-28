using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfxController : MonoBehaviour
{
    public AudioClip sound;
    AudioSource audio;

    void Start(){
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetKeyUp("space")){
            audio.PlayOneShot(sound,1f);
        }
    }
}
