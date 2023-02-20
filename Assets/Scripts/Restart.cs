using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    //
    //
    private void Start()
    {
        Debug.Log("Restart Scrpit Started!");
    }
    
    
    public void OnButtonPress()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
