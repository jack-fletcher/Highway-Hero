using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class highScoreScript : MonoBehaviour {
    public TextMeshProUGUI score = null;
    public TextMeshProUGUI highScore = null;
    public TextMeshProUGUI coins = null;
    public GameObject deathPanel;
    // Use this for initialization

    private void Start()
    {
        deathPanel.SetActive(false);
    }
    void Awake() {

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
      
     //   score.text = "Score:" + " " + scoreScript.score;
     //   highScore.text = "Local HighScore:" + " " + PlayerPrefs.GetInt("highScore");
     //coins.text = "You collected" + " " + PlayerScript.currentCoin + " Coin(s)";
	}
	
	// Update is called once per frame
	void Update () {
       // Debug.Log(PlayerPrefs.GetInt("highScore"));
		if (CrashScript.isDead == true)
        {
            deathPanel.SetActive(true);
                    score.text = "Score:" + " " + scoreScript.score;
        highScore.text = "Local HighScore:" + " " + PlayerPrefs.GetInt("highScore");
     coins.text = "You collected" + " " + PlayerScript.currentCoin + " Coin(s)";
        }
	}
}
