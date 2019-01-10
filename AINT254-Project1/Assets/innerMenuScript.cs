using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class innerMenuScript : MonoBehaviour {

    public TextMeshProUGUI titleText;
    public TextMeshProUGUI innertext;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}


   public void controlsOnClick()
    {
        titleText.text = "Controls";
        innertext.text = "W - Move Faster /n S - Move Slower /n A - Move left by a lane /n D - Move right by a lane /n ESC - Pause / Unpause the game";
    }
}
