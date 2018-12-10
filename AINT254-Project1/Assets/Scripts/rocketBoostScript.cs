using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketBoostScript : MonoBehaviour {
    public float previousSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        particleChangerScript.isBoosted = true;

        previousSpeed = movementScript.baseSpeed;
        movementScript.boosted = true;
        movementScript.baseSpeed = 150;
        StartCoroutine("Boosted");
        
     //   Destroy(this.gameObject);
    }

    IEnumerator Boosted()
    {
        yield return new WaitForSeconds(2f);
            movementScript.boosted = false;
        movementScript.baseSpeed = previousSpeed;
        particleChangerScript.isBoosted = false;
        Debug.Log("No longer boosted");
        Destroy(this.gameObject);
    }
}
