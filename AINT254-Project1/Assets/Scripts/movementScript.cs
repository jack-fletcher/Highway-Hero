using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour {
    //base car speed
    public float baseSpeed = 10.0f;
    //user turn input
    public float turnInput;
    //turn speed
    public float turnSpeed = 5.0f;
    public Rigidbody car;
    //where I want to go 
    
	// Use this for initialization
	void Start () {

        car = GetComponent<Rigidbody>();
       
	}
    private void Update()
    {
        turnInput = Input.GetAxis("Horizontal");

    }
    // Update is called once per frame
    void FixedUpdate () {
        //keeps car going perpetually forward
        car.velocity = transform.forward * baseSpeed;

        
        car.AddRelativeTorque(0f, turnInput * turnSpeed, 0f);
       
        //if (Input.GetKeyUp(KeyCode.A))
        //{
        //    Debug.Log("You moved left!");

        //    transform.Translate (new Vector3(-10, 0, 0)); 

        //}
        //if (Input.GetKeyUp(KeyCode.D))
        //{
        //    Debug.Log("You moved right!");
        //     transform.Translate(new Vector3(10, 0, 0));
        //    car.AddForce(transform.forward * force);

        //}
    }
}
