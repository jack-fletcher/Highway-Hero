using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour {
    //base car speed 
    public static float baseSpeed = 50.0f;
    public static float maxSpeed = 100f;
    public static float minSpeed = 20f;
    //the amount the car moves
    public float horizontalMovement = 0;
    public float startingLane = 0;
    public float highestLane = 1;
        public float lowestLane = -1;
    public static float turnSpeed = 0.5f;
    public float currentLane;
    public Rigidbody car;
    //is car currently turning
    public bool isTurning = false;
   //x values should be -10, 0, 10
    
	// Use this for initialization
	void Start () {
        //get currentlane
        baseSpeed = 50f;
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
            horizontalMovement = horizontalMovement - 20;
            currentLane -= 1;
            isTurning = true;
           // Debug.Log(currentLane);
            StartCoroutine(stopMovement());
            //Debug.Log(horizontalMovement);

        }
        if ((Input.GetAxis("Horizontal") > 0) && (isTurning == false) && currentLane < highestLane)
        {
            horizontalMovement = horizontalMovement + 20;
            currentLane += 1;
            isTurning = true;
            StartCoroutine(stopMovement());
            //  Debug.Log(currentLane);
            //Debug.Log(horizontalMovement);


        }
    }

    //routine that stops movement after waiting for x number of seconds and resets isTurning
    IEnumerator stopMovement()
    {
        yield return new WaitForSeconds(turnSpeed);
        horizontalMovement = 0;
        isTurning = false;
if (currentLane == -1) {
            car.position = new Vector3(-10, car.transform.position.y, car.transform.position.z);
        }
        if (currentLane == 0) {
            car.position = new Vector3(0, car.transform.position.y, car.transform.position.z);

        }
        if (currentLane == 1) {
            car.position = new Vector3(10, car.transform.position.y, car.transform.position.z);

        }
    }
}
