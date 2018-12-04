using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreScript : MonoBehaviour {
    private float timer;
    public static float score;
    public float scoreMultiplier = 1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        timer += Time.deltaTime;
        scoreMultiplier = (float)Math.Round(movementScript.baseSpeed / 10);
        if (timer > 1f)
        {
            score += 1 * scoreMultiplier;

            timer = 0;
        }
    }
}
