using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscore : MonoBehaviour
{
    public GameObject gameover;
    public GameObject score;
    public int param;
    private string barisan;
    public Sprite[] huruf;
    public int[] angka;
    public MultiDimensional[] finalText;

    void Start()
    {
        param = 0;
        for (int i = 0; i < 5; i++){
            if(PlayerPrefs.HasKey("highscore"+i)){
                
            }else{
                PlayerPrefs.SetInt("highscore"+i,0);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameover.activeSelf && param == 0){
            int m = 0;
            for(; m < 5; m++){
                if((int)score.GetComponent<scoring>().jumlah>PlayerPrefs.GetInt("highscore"+m)&&(m+1)<5){
                    PlayerPrefs.SetInt("highscore"+(m+1),PlayerPrefs.GetInt("highscore"+m));
                    break;
                }
            }
            Debug.Log(m+" "+(int)score.GetComponent<scoring>().jumlah);
            PlayerPrefs.SetInt("highscore"+m,(int)score.GetComponent<scoring>().jumlah);
            Debug.Log("Coba");
            param++;
            for (int l = 0; l < 5; l++)
            {
                barisan = (PlayerPrefs.GetInt("highscore"+l)+"").PadLeft(4,'0');
                for (int k = 0; k < 4; k++)
                {
                    angka[k] = int.Parse(barisan.Substring(k,1));
                }
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if(angka[i] == j){
                            finalText[l].imageArray[i].GetComponent<Image>().sprite = huruf[j];
                        }
                    }
                }
            }
        }
    }
}

[System.Serializable]
 public class MultiDimensional
 {
 public Image[] imageArray;
 }