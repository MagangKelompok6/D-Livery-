using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuControl : MonoBehaviour
{
    public GameObject pausepanel;
    public GameObject score;
    public GameObject bar;
    public bool isPause;
    public Camera cam;

    public void exitGame(){
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void backToMenu(){
        Time.timeScale = 1;
        SceneManager.LoadScene("pre progress");
    }

    public void restartGame(){
        Time.timeScale = 1;
        cam.GetComponent<cameraMovement>().transform.position = new Vector3(-10,2.393159f,-100);;
        cam.GetComponent<cameraMovement>().isPause = false;
        pausepanel.SetActive(false);
        score.GetComponent<scoring>().jumlah = 0;
    }

    void Start(){
    }

    void Update()
    {
        
    }
}
