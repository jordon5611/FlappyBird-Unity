using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody BirdRB;
    public Button RestartButton;
    bool flag = true;
    void Start()
    {
        BirdRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame

    float force = 5f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && transform.position.y < 2.3 ){
            BirdRB.AddForce(Vector3.up * force, ForceMode.Impulse ); 
        }
        if (transform.position.y > 2.3) {
            transform.position = new Vector3(transform.position.x, 2.3f, transform.position.z);
        }
        if (transform.position.y < -2.26)
        {
            RestartButton.gameObject.SetActive(true);
            if (flag) {
                Time.timeScale = 0;
                flag = false;
            }
            
        }
    }
}
