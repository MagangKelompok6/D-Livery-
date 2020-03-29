using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuControl : MonoBehaviour
{
    public GameObject pausepanel;
    public GameObject mainmenu;
    public GameObject score;
    public GameObject bar;
    public bool isPause;
    public Camera cam;
    public GameObject player;
    public GameObject generator;

    public void exitGame(){
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void backToMenu(){
        Time.timeScale = 1;
        SceneManager.LoadScene("pre progress");
    }

    public void restartGame(){
        PlayerPrefs.SetInt("isQuit",0);
        backToMenu();
    }

    void Start(){
        
    }

    void Update()
    {

    }
    
    void OnApplicationQuit() {
        PlayerPrefs.SetInt("isQuit",1);
    }
}
