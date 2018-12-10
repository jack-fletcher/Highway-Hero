using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseUI : MonoBehaviour {
    private bool paused = false;
    public GameObject pauseUI;
	// Use this for initialization
	void Start () {
        pauseUI.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Pause"))
        {
            Resume();
        }
	}
public void restart()
    {

    }
    public void mainMenu()
    {
        SceneManager.LoadScene("startScreen");
    }
    public void Resume()
    {
        
            paused = !paused;
        
        if (paused)
        {
            pauseUI.SetActive(true);

            AudioListener.volume = 0f;
            Time.timeScale = 0;
        }
        else if (!paused)
        {
            AudioListener.volume = 1f;
            pauseUI.SetActive(false);
            Time.timeScale = 1;
        }
    }
    public void Quit()
    {
        Application.Quit();
    }
}
