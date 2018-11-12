using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : MonoBehaviour {
 //  int currentCoin = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player"))
        {PlayerScript.currentCoin = PlayerScript.currentCoin + 1;
            Destroy(gameObject);
            Debug.Log(PlayerScript.currentCoin);
        }
    }
}
