using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject SCylinder;
    public GameObject UPCylinder;
    public bool isGameStop = false;
    void Start()
    {
        
        InvokeRepeating("RespawnStraight", Random.Range(1,4), Random.Range(1,4));
        InvokeRepeating("RespawnUP", Random.Range(1,4), Random.Range(1,4));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RespawnStraight(){
        if(!isGameStop){

            Instantiate(SCylinder , new Vector3(0, Random.Range(-1.18f, -2.0f) , -0.4f), SCylinder.transform.rotation);
        }
    }

    void RespawnUP(){
        if(!isGameStop){
            Instantiate(UPCylinder , new Vector3(0, Random.Range(1.2f, 2.0f) , -0.4f), UPCylinder.transform.rotation);
        }
    }
}
