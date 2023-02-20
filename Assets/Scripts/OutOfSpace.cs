using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfSpace : MonoBehaviour
{
    // Start is called before the first frame update
    GetScore TScore;
    
    void Start()
    {
        TScore = FindObjectOfType<GetScore>();
        
    }


    // Update is called once per frame
    void Update()
    {

        if(transform.position.x <= -4){
            TScore.setscore(1);
            Destroy(gameObject);
        }

    }
}
