using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class highScoreScript : MonoBehaviour {
    public Text score = null;
    public Text highScore = null;
    private 
	// Use this for initialization
	void Start () {
        if (PlayerPrefs.HasKey("highScore"))
        {
            if (PlayerPrefs.GetInt("highScore") < scoreScript.score)
            {
                PlayerPrefs.SetInt("highScore", (int)scoreScript.score);
            }
        }
        else PlayerPrefs.SetInt("highScore", (int)scoreScript.score);
        
        score.text = "Score:" + " " + scoreScript.score;
        highScore.text = "Local HighScore:" + " " + PlayerPrefs.GetInt("highScore");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
