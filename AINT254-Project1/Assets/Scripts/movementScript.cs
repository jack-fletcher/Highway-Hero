using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour {
    //base car speed
    public float baseSpeed = 10.0f;
    //user input
    public float speedInput;
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
        speedInput = Input.GetAxis("Vertical");
    }
    // Update is called once per frame
    void FixedUpdate () {
        //keeps car going perpetually forward
        car.velocity = transform.forward * baseSpeed;
       // car.AddRelativeForce(0f, 0f, speedInput * baseSpeed );
        //turn left or right
        car.AddRelativeTorque(0f, turnInput * turnSpeed, 0f);
       
    }
}
