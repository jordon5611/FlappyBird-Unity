using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    BackGround Back;
    CyclinderMove CMove;
    SpawnManager Smanager;
    BirdController Bird;
    public Button RestartButton;
    void Start()
    {
        Bird = FindObjectOfType<BirdController>();
        Smanager = FindObjectOfType<SpawnManager>();
        CMove = FindObjectOfType<CyclinderMove>();
        Back = FindObjectOfType<BackGround>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other){

        //Bird.BirdRB.useGravity = false;
        //Bird.isGameStop = true;
        //Bird.BirdRB.constraints = RigidbodyConstraints.FreezePosition;
        //Back.speed = 0;
        //CMove.isGameStop = true;
        //Smanager.isGameStop = true;
        
        RestartButton.gameObject.SetActive(true);
        Time.timeScale = 0;

    }

    



}
