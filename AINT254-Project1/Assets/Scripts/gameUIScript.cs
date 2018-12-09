using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameUIScript : MonoBehaviour
{
    public Text score = null;
    public Text coins = null;
    public Text speed = null;
    private Rect Menu = new Rect(10, 10, 190, 190);
    public Text Lives = null;
    bool isPaused;

    void Start()
    {
        isPaused = false;
    }

    void OnGUI()
    {
        //GUI.skin.button.fontSize = 60;
        //GUI.skin.box.fontSize = 60;
        //if (!isPaused)
        //{
        //    if (GUI.Button(Menu, "Pause"))
        //    {
        //        Time.timeScale = 0f;
        //        isPaused = true;
        //    }
        //}
        //if (isPaused)
        //{
        //    if (GUI.Button(Menu, "Play"))
        //    {
        //        Time.timeScale = 1.0f;
        //        isPaused = false;
        //    }
        //}
        score.text = "Score:" + " " + scoreScript.score;
        coins.text = "Coins:" + " " + PlayerScript.currentCoin;
        speed.text = "Speed:" + " " + movementScript.baseSpeed;
        Lives.text = "Lives:" + " " + PlayerScript.lives;

    }
}