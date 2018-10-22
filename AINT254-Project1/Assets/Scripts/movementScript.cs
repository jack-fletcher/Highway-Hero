using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour {
    //base car speed 
    public static float baseSpeed = 30.0f;
    public float maxSpeed = 100f;
    public float minSpeed = 20f;
    //the amount the car moves
    public float horizontalMovement = 0;
   
    public float startingLane = 0;
    public float highestLane = 1;
        public float lowestLane = -1;
    public float currentLane;
    public Rigidbody car;
    //is car currently turning
    public bool isTurning = false;
   
    
	// Use this for initialization
	void Start () {
        //get currentlane
        currentLane = startingLane;
        car = GetComponent<Rigidbody>();
     
	}
    // Update is called once per frame
    void FixedUpdate()
    {
        //keeps car going perpetually forward and adds variable for left/right movement
        car.velocity = new Vector3(horizontalMovement, 0, baseSpeed);


        if ((Input.GetAxis("Vertical") > 0 && baseSpeed < maxSpeed))
        {
            baseSpeed += 1f;

        }

        if ((Input.GetAxis("Vertical") < 0 && baseSpeed > minSpeed))
        {
            baseSpeed -= 1f;
        }

        //turn left or right and stop rapid tapping a/d with isTurning
        if ((Input.GetAxis("Horizontal") < 0)  &&  (isTurning == false) && currentLane > lowestLane)
        {
            horizontalMovement = -20;
            currentLane -= 1;
            isTurning = true;
            Debug.Log(currentLane);
            StartCoroutine(stopMovement());
        }
        if ((Input.GetAxis("Horizontal") > 0) && (isTurning == false) && currentLane < highestLane)
        {
            horizontalMovement += 20;
            currentLane += 1;
            isTurning = true;
            StartCoroutine(stopMovement());
            Debug.Log(currentLane);
            //  car.AddRelativeTorque(0f, turnInput * turnSpeed, 0f);

        }
    }

    //routine that stops movement after waiting for x number of seconds and resets isTurning
    IEnumerator stopMovement()
    {
        yield return new WaitForSeconds(0.5f);
        horizontalMovement = 0;
        isTurning = false;
    }
}
