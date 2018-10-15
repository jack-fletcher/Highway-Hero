using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMovementScript : MonoBehaviour {
    public float baseSpeed = 2;
    public Rigidbody cube;
	// Use this for initialization
	void Start () {
        cube = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        //traffic movement
        cube.velocity = transform.forward * baseSpeed;
    }
}
