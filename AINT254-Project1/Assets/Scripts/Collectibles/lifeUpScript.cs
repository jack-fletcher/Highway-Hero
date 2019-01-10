using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeUpScript : MonoBehaviour {
    private AudioSource pickup;
    private Renderer renderer;
    // Use this for initialization
    void Start () {
        pickup = GetComponent<AudioSource>();
        renderer = GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            PlayerScript.lives = PlayerScript.lives + 1;
            pickup.Play();
            renderer.enabled = false;
            Destroy(gameObject, 5f);
        }
    }
}
