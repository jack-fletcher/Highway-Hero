using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CloseCallScript : MonoBehaviour {
   // public Text closeCall;
    // Use this for initialization

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Close call!");
     //   closeCall.text = ("Close call!");
    }

    void Start () {
       // closeCall.text = "";		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
