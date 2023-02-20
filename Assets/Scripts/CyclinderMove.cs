using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyclinderMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public bool isGameStop = false;

    // Update is called once per frame
    public float speed = 3f;
    void Update()
    {
        if(!isGameStop){
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        
    }
}
