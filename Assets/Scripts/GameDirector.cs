using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public GameObject timerText;
    public GameObject pointText;
    float time = 30.0f;
    int point = 0;
    public GameObject generator;

    public void GetApple(){
        this.point += 100;
    }
    public void GetBomb(){
        this.point /= 2;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       this.time -= Time.deltaTime;

       if(this.time<0){
        this.time = 0;
        this.generator.GetComponent<ItemGenerator>().SetParameter(
            10000.0f,0,0);
       }  else if(0 <= this.time && this.time <6){
        this.generator.GetComponent<ItemGenerator>().SetParameter(
            0.3f,-0.06f,1);
       }  else if(6 <= this.time && this.time <12){
        this.generator.GetComponent<ItemGenerator>().SetParameter(
            0.5f,-0.05f,6);
       }  else if(12 <= this.time && this.time <23){
        this.generator.GetComponent<ItemGenerator>().SetParameter(
            0.8f,-0.04f,4);
       }  else if(23 <= this.time && this.time <30){
        this.generator.GetComponent<ItemGenerator>().SetParameter(
            1.0f,-0.03f,2);
       }
       this.timerText.GetComponent<TextMeshProUGUI>().text=
       this.time.ToString("F1"); 
       this.pointText.GetComponent<TextMeshProUGUI>().text=
       this.point.ToString() + " point" ; 
    }
}
