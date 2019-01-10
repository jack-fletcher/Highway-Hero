using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class gameUIScript : MonoBehaviour
{
    public TextMeshProUGUI score = null;
    public TextMeshProUGUI coins = null;
    public TextMeshProUGUI speed = null;
    public TextMeshProUGUI Lives = null;
    

    void Start()
    {
    }

    private void Update()
    {
        score.text = "Score:" + " " + scoreScript.score;
        coins.text = "Coins:" + " " + PlayerScript.currentCoin;
        speed.text = "Speed:" + " " + PlayerMovement.currentSpeed;
        Lives.text = "Lives:" + " " + PlayerScript.lives;
    }
}