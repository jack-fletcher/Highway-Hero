using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class obstacleDestruction : MonoBehaviour {
  
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerExit(Collider other)
    {
        StartCoroutine(delay());
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
