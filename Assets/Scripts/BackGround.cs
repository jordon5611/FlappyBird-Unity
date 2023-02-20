using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 startingPos;
    float size;
    
    void Start() 
    {
        startingPos = transform.position;
        size = GetComponent<BoxCollider>().size.x;
        
    }

    // Update is called once per frame
    public float speed = 1f;
    void Update()
    {
        if(-(transform.position.x) - startingPos.x > size + 0.52 ){
            transform.position = startingPos;
        }
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        
    }
}
