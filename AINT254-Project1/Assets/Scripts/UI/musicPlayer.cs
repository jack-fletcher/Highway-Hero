using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class musicPlayer : MonoBehaviour
{
    public GameObject music;
    bool isPlaying;
    public Slider slider;
    public Sprite muted;
    public Sprite unmuted;
    public Button button;
    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.HasKey("Volume"))
        {
            AudioListener.volume = PlayerPrefs.GetFloat("Volume");
            slider.normalizedValue = (PlayerPrefs.GetFloat("Volume"));
        }
        else AudioListener.volume = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value == 0)
        {
            button.image.sprite = muted;
        }
        else
        {
            button.image.sprite = unmuted;
        }


        if (!GameObject.FindGameObjectWithTag("Music"))
        {
            Instantiate(music);
            DontDestroyOnLoad(GameObject.FindGameObjectWithTag("Music"));
        }

       
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
