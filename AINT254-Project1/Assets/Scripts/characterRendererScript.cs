using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterRendererScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerScript.invincible == true)
        {
            for (int i = 0; i < 10; i++)
            {
                GetComponent<Renderer>().enabled = false;

                StartCoroutine("Flash");

            }
        }
	}

    IEnumerator Flash()
    {
        yield return new WaitForSeconds(0.2f);
        GetComponent<Renderer>().enabled = true;

    }
}
