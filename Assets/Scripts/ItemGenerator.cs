using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject bombPrefab;
    float span = 1.0f;
    float delta = 0;
    int ratio = 2;
    float speed = -0.03f;

    public void SetParameter(float span,float speed,int ratio){
        this.span = span;
        this.speed = speed;
        this.ratio = ratio;
    }

    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span){
            this.delta = 0;
            GameObject itme;
            int dice = Random.Range(1,11);
            if(dice <= this.ratio){
                itme=Instantiate(bombPrefab);
            } else {
                itme=Instantiate(applePrefab);
            }
            float x = Random.Range(-1,2);
            float z = Random.Range(-1,2);
            itme.transform.position = new Vector3(x,4,z);
            itme.GetComponent<ItemController>().dropSpeed=this.speed;
        }
    }
}
