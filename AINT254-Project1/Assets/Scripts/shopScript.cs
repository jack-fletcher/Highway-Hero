using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class shopScript : MonoBehaviour {
    public Text Coins = null;
	// Use this for initialization
	void Start ()
    {
        if (PlayerPrefs.HasKey("coins"))
        {

            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + PlayerScript.currentCoin);



        }

        else
        {
            PlayerPrefs.SetInt("coins", (int)PlayerScript.currentCoin); }

            Coins.text = "Coins:" + " " + PlayerPrefs.GetInt("coins");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
