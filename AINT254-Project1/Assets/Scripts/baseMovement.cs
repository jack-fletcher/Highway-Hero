using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseMovement : MonoBehaviour {
    //default speed
    public float speed = 30;
    public float horizontalMovement;
    public Rigidbody car;
	// Use this for initialization
	void Start () {
        Initialise();
	}
	
	// Update is called once per frame
	void Update () {
       
	}
    public virtual void Initialise()
    {
        car = GetComponent<Rigidbody>();
    }
    protected virtual void Movement()
    {
        car.velocity = new Vector3(horizontalMovement, 0, speed);
    }
}
