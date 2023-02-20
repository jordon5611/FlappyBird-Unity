using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{
    // Start is called before the first frame update
    
    public int score = 0;
    public TextMeshProUGUI scoreUI;

    void Start()
    {
        scoreUI.text = "Score: " + score.ToString();
        
    }
    public void setscore(int scoretoadd)
    {
        score += scoretoadd;
        scoreUI.text = "Score: " + score.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
