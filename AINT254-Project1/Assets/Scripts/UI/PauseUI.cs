using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PauseUI : MonoBehaviour {
    private bool paused = false;
    public Slider slider;
    public Sprite muted;
    public Sprite unmuted;
    public Button button;
    public GameObject pauseUI;
	// Use this for initialization
	void Start () {
       // AudioListener.volume = 1f;
        pauseUI.SetActive(false);
        Time.timeScale = 1;
        if (PlayerPrefs.HasKey("Volume"))
        {
            AudioListener.volume = PlayerPrefs.GetFloat("Volume");
            slider.normalizedValue = (PlayerPrefs.GetFloat("Volume"));
        }
        else AudioListener.volume = 1;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Pause"))
        {
            Resume();
        }
        if (slider.value == 0)
        {
            button.image.sprite = muted;
        }
        else
        {
            button.image.sprite = unmuted;
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

            AudioListener.pause = true;
            Time.timeScale = 0;
        }
        else if (!paused)
        {
            AudioListener.pause = false;
            pauseUI.SetActive(false);
            Time.timeScale = 1;
        }
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void OnSliderChange()
    {
        AudioListener.volume = slider.value;
        PlayerPrefs.SetFloat("Volume", AudioListener.volume);
    }
    public void muteOnClick()
    {
        if (AudioListener.volume > 0)
        {
            AudioListener.volume = 0;
        }
        else if (AudioListener.volume == 0)
        {
            AudioListener.volume = 1;

        }
        slider.value = AudioListener.volume;
    }
}
