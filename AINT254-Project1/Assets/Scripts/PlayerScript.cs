using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    public static int currentCoin = 0;
    public static int lives;
    public static bool invincible = false;
    // Use this for initialization
    void Start () {
        currentCoin = 0;
        lives = 3;
    }
	
	// Update is called once per frame
	void Update () {
        if (invincible == true)
        {
            StartCoroutine("Timer");
        }
	}



    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.5f);
        PlayerScript.invincible = false;
        Debug.Log("You are no longer invincible!");
        
    }
}
