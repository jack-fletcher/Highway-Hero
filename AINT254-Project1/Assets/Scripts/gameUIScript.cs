using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameUIScript : MonoBehaviour
{

    private Rect Menu = new Rect(10, 10, 190, 190);
    private Rect scoreBox = new Rect(Screen.width - 200, Screen.height - 200, 190, 190);
    bool isPaused;
    public static int scoreText;

    void Start()
    {
        isPaused = false;
    }

    void OnGUI()
    {
        GUI.skin.button.fontSize = 60;
        GUI.skin.box.fontSize = 60;
        if (!isPaused)
        {
            if (GUI.Button(Menu, "Pause"))
            {
                Time.timeScale = 0f;
                isPaused = true;
            }
        }
        if (isPaused)
        {
            if (GUI.Button(Menu, "Play"))
            {
                Time.timeScale = 1.0f;
                isPaused = false;
            }
        }
        GUI.Box(scoreBox, ("Score:" + "\n" + scoreScript.score));
    }
}