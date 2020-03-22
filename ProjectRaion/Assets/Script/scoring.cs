using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoring : MonoBehaviour
{
    public bool jalan;
    public Image[] scoreText;
    public Sprite[] huruf;
    public Image[] finalText;
    public float jumlah;
    public float penambahan;
    public GameObject gameover;
    private string barisan;
    public int[] angka;
    // Start is called before the first frame update
    void Start()
    {
        jumlah = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(jalan){
            int l = (int) jumlah;
            barisan = (l+"").PadLeft(4,'0');
            for (int k = 0; k < 4; k++)
            {
                angka[k] = int.Parse(barisan.Substring(k,1));
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if(angka[i] == j){
                        scoreText[i].GetComponent<Image>().sprite = huruf[j];
                    }
                }
            }
            jumlah += penambahan*Time.deltaTime;
        }
        if(gameover.activeSelf){
            int l = (int) jumlah;
            barisan = (l+"").PadLeft(4,'0');
            for (int k = 0; k < 4; k++)
            {
                angka[k] = int.Parse(barisan.Substring(k,1));
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if(angka[i] == j){
                        finalText[i].GetComponent<Image>().sprite = huruf[j];
                    }
                }
            }
        }
    }
    public void score(){
        jalan = true;
    }
}
