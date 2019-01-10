using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class policeLightTimer : MonoBehaviour {
    public Light redLight;
    public Light blueLight;
    private float timer = 0f;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer == 0.5)
        {
            redLight.enabled = !redLight.enabled;

            
        }
        if (timer == 1)
        {
            blueLight.enabled = !blueLight.enabled;
            timer = 0;
        }
    }
}
