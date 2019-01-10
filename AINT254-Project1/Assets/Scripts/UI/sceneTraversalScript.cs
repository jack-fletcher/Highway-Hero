using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class sceneTraversalScript : MonoBehaviour {
    private AudioSource clickSound;

    private void Start()
    {
        
    }
    public void startGame()
    {

            SceneManager.LoadScene("LoadingScene"); 
    }
    public void restartGame()
    {
        SceneManager.LoadScene("startScreen");
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("startScreen");
    }
    public void credits()
    {
        SceneManager.LoadScene("credits");
    }
    public void controls()
    {
        SceneManager.LoadScene("controls");
    }
    public void quitGame()
    {
        Application.Quit();
    }
    public void loadShop()
    {
        SceneManager.LoadScene("ShopScene");
    }

}
