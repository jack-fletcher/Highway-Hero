using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class highScoreScript : MonoBehaviour {
    public Text score = null;
    public Text highScore = null;
    public Text coins = null;
    private
    // Use this for initialization
    void Start() {
        coins.text = "Coins:" + " " + "0";
        if (PlayerPrefs.HasKey("highScore"))
        {
            if (PlayerPrefs.GetInt("highScore") < scoreScript.score)
            {
                PlayerPrefs.SetInt("highScore", (int)scoreScript.score);
            }
        }
        if (PlayerPrefs.HasKey("coins"))
        {

            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + PlayerScript.currentCoin);



        }
        else
        {
            PlayerPrefs.SetInt("coins", (int)PlayerScript.currentCoin);
            PlayerPrefs.SetInt("highScore", (int)scoreScript.score);
        }
      
        score.text = "Score:" + " " + scoreScript.score;
        highScore.text = "Local HighScore:" + " " + PlayerPrefs.GetInt("highScore");
     coins.text = "You collected" + " " + PlayerScript.currentCoin + " Coin(s)";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
