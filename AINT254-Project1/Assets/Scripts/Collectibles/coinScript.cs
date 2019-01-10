using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : MonoBehaviour {
    //  int currentCoin = 0;
    // Use this for initialization
    private AudioSource pickup;
    private Renderer renderer;
	void Start () {
        pickup = GetComponent<AudioSource>();
        renderer = GetComponent<MeshRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}



    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player"))

        {
            pickup.Play();
            PlayerScript.currentCoin = PlayerScript.currentCoin + 1;
            scoreScript.score = scoreScript.score + 10;
            renderer.enabled = false;
            Destroy(gameObject, 5f);
        }
    }
}
