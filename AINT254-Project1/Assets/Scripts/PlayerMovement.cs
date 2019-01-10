using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : baseMovement {
    //base car speed 
    //the amount the car moves
    //public float horizontalMovement = 0;
    public float startingLane = 0;
    public float highestLane = 1;
    public static float currentSpeed;
        public float lowestLane = -1;
    public static float turnSpeed = 0.1f;
    public static bool boosted = false;
    public float currentLane;
    public AudioSource tyres;
    float timer;
    //is car currently turning
    public bool isTurning = false;
    
   //x values should be -10, 0, 10
    
	// Use this for initialization
	void Start () {
        //get currentlane
        speed = 50;
        currentSpeed = speed;
        timer = 0;
        currentLane = startingLane;
        car = GetComponent<Rigidbody>();
        tyres = GetComponent<AudioSource>();

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }

    protected override void Movement()
    {
        //keeps base class functionality
        base.Movement();
        //increases speed every 3 seconds by 2
        timer += Time.deltaTime;
        if (timer > 3 && currentSpeed < 100)
        {
            currentSpeed += 2f;
            timer = 0;
            //for gui
            speed = currentSpeed;
        }



        //turn left or right and stop rapid tapping a/d with isTurning
        if ((Input.GetButton("Left")) && (isTurning == false) && currentLane > lowestLane)
        {
            //car.MovePosition(transform.position - transform.right * 10);
        //    car.position = new Vector3(car.transform.position.x - 10, car.transform.position.y, car.transform.position.z);

              horizontalMovement = horizontalMovement - 100;
            currentLane -= 1;
            isTurning = true;
            StartCoroutine(StopMovement());
            
        }
        if ((Input.GetButton("Right")) && (isTurning == false) && currentLane < highestLane)
        {

          //  car.position = new Vector3(car.transform.position.x + 10, car.transform.position.y, car.transform.position.z);
            horizontalMovement = horizontalMovement + 100;
            currentLane += 1;
            isTurning = true;
            StartCoroutine(StopMovement());
            

        }
    }
    //routine that stops movement after waiting for x number of seconds and resets isTurning 
    IEnumerator StopMovement()
    {
        yield return new WaitForSeconds(turnSpeed);
        FixPosition();

        horizontalMovement = 0;
        isTurning = false;
       
    }

    void FixPosition()
    {
        if (currentLane == -1)
        {
            car.position = new Vector3(-10, car.transform.position.y, car.transform.position.z);
        }
        if (currentLane == 0)
        {
            car.position = new Vector3(0, car.transform.position.y, car.transform.position.z);

        }
        if (currentLane == 1)
        {
            car.position = new Vector3(10, car.transform.position.y, car.transform.position.z);

        }
    }
}
