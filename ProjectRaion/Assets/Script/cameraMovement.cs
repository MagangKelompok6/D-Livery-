using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public Vector3[] Target;
    public Camera Cam;
    public bool zoomCamera;
    public float speed=5f;
    public float jumlah;
    public float penambahan;
    public bool isPause;
    public GameObject nyawa;
    public GameObject gameover;
    public GameObject pausepanel;
    public GameObject menupanel;
    public GameObject bar;
    public GameObject score;
    public Sprite blur;
    private GameObject[] background;
    // Start is called before the first frame update
    void Start()
    {
        jumlah = 0f;
        penambahan = 2f;
        Cam = Camera.main;
        if(PlayerPrefs.HasKey("isQuit")){
            if(PlayerPrefs.GetInt("isQuit")==0){
                zoomCamera = true;
                isPause = false;
                Cam.GetComponent<cameraMovement>().zoomCamera = true;
                menupanel.SetActive(false);
                bar.SetActive(true);
                score.GetComponent<scoring>().jalan = true;
                PlayerPrefs.SetInt("isQuit",1);
            }else{
                zoomCamera = false;
                PlayerPrefs.SetInt("isQuit",1);
            }
        }else{
            zoomCamera = false;
            PlayerPrefs.SetInt("isQuit",1);
        }
        isPause = false;
        nyawa = GameObject.Find("Player");
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape)){
            isPause = isPause==true?false:true;
            if(menupanel.activeSelf==false){
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
        if(zoomCamera){
            int i = (int) jumlah;
            if( i < 2){
                Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize,10,speed*Time.deltaTime);
                Cam.transform.position = Vector3.Lerp(Cam.transform.position,Target[0], speed*Time.deltaTime);
            }else if(isPause){

            }
            else if(nyawa.GetComponent<health>().healths==0){
                background = GameObject.FindGameObjectsWithTag("background");
                foreach (GameObject backgrounds in background)
                {
                    backgrounds.GetComponent<SpriteRenderer>().sprite = blur;
                }
                gameover.SetActive(true);
                bar.SetActive(false);
            }
            else{
                transform.position += new Vector3(.2f,0,0);
                nyawa.GetComponent<Animator>().SetBool("isStart",true);
            }
            jumlah += penambahan*Time.deltaTime;
        }
    }
    public void OnMouseDown() {
        if (Input.GetKeyUp(KeyCode.Mouse0)){
            zoomCamera = true;
        }
    }
}
