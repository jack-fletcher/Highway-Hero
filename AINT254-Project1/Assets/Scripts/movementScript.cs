using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour {

    public float force = 3000;
    public Rigidbody car;
	// Use this for initialization
	void Start () {

        car = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

       
        if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("A thing was done!");
            car.AddForce(Vector3.left * force);
            
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("A thing was done!");
            car.AddForce(Vector3.right * force);

        }
    }
}
