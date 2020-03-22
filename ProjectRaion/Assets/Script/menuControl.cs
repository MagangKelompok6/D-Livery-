using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuControl : MonoBehaviour
{
    public GameObject pausepanel;
    public GameObject menupanel;
    public bool isPause;

    public void exitGame(){
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void backToMenu(){
        Time.timeScale = 1;
        SceneManager.LoadScene("pre progress");
    }

    void Start(){
        isPause = false;
    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape)){
            if(menupanel.activeSelf==false){
                isPause = isPause==true?false:true;
                if(isPause==true){
                    Time.timeScale = 0;
                    pausepanel.SetActive(true);
                }
                else{
                    Time.timeScale = 1;
                    pausepanel.SetActive(false);
            
                }
            }
        }
    }
}
